// Required
const cors = require('cors');
const express = require('express');
const uuid = require('uuid');
const { Client } = require('./client');

//Static fields
const clientCollection = 'clients';

function CreateClientServer(_db) {

  //Server setup
  const db = _db;
  const clientsServer = express();
  clientsServer.use(cors({
    origin: true
  }));

  //GET All clients
  clientsServer.get('/clients', async (request, response) => {
    const docRef = db.collection(clientCollection);
    let clientsSnapshot = await docRef.get();
    let clients = clientsSnapshot.docs.map(doc => {return doc.data();})
    var clientsObj = { "clients" : clients};
    response.json(clientsObj);
  });

  //Create client
  clientsServer.post('/client', async (request, response) => {
    let name = request.body["fullname"];
    let gender = request.body["gender"];
    let newClientId = uuid.v1();
    let docRef = db.collection(clientCollection).doc(newClientId);
    var client = new Client(newClientId, name,gender);
    await docRef.set(JSON.parse(JSON.stringify(client)));
    response.send(
      'Client with name ' + client.fullname + ' created!'
    );
  });

  //Delete client
  clientsServer.post('/client/delete/:id', async (request, response) => {
    let deleteDoc = await db.collection(clientCollection).doc(request.params.id).delete();
    response.send(
      'Client with id ' + request.params.id + ' deleted!'
    );
  });

  return clientsServer;
}

module.exports = {
  CreateClientServer
};