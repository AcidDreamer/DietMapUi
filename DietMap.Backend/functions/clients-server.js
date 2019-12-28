const cors = require('cors');
const express = require('express');
const uuid = require('uuid');
const clientCollection = 'clients';

function CreateClientServer(_db) {
  const db = _db;
  const clientsServer = express();
  clientsServer.use(cors({
    origin: true
  }));

  clientsServer.get('/clients', (request, response) => {
    // var data = [];
    // let kati = db.collection(clientCollection).get()
    //   .then((snapshot) => {
    //     snapshot.forEach((doc) => {
    //       data.push(doc);
    //     });
    //     return data;
    //   })
    //   .catch((err) => {
    //     console.error('Error getting documents', err);
    //   });

    const docRef = db.collection(clientCollection);
    docRef.get()
      .then(snapshot => {
        let arrayR = snapshot.docs.map(doc => {
          return doc.data();
        });
        response.json(arrayR);
        return null;
      }).catch(function (error) {
        console.error("got an error", error);
      })

  });

  clientsServer.post('/client', (request, response) => {
    let name = request.body["fullname"];
    let newClientId = uuid.v1();
    let docRef = db.collection(clientCollection).doc(newClientId);
    let setAda = docRef.set({
      fullname: name,
      lastVisit: null,
      createdAt: new Date()
    });
    response.send(
      'Client with name ' + client.fullname + ' created!'
    );
  });
  clientsServer.post('/test', (request, response) => {
    response.send(
      'Test post received!'
    );
  });
  clientsServer.get('/test', (request, response) => {
    let newClientId = uuid.v1();
    let docRef = db.collection(clientCollection).doc(newClientId);
    var client = new Client();
    let setAda = docRef.set({
      id : newClientId,
      fullname: "Test",
      lastVisit: null,
      createdAt: new Date()
    });
    response.send(
      'Client for testing created!'
    );
  });

  return clientsServer;
}

module.exports = {
  CreateClientServer
};