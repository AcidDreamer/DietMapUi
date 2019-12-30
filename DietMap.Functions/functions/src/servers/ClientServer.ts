// Required
import * as cors from 'cors';
import * as express from 'express';
import * as uuid from 'uuid';
import { Client } from '../entities/Clients';
import { firestore } from 'firebase-admin';

const ClientCollection = 'clients';

//Static fields
export function CreateClientServer(_db: firestore.Firestore): express.Application {

    //Server setup
    const db = _db;
    const clientsServer = express();
    clientsServer.use(cors({
        origin: true
    }));

    //GET All clients
    clientsServer.get('/clients', async (request, response) => {
        const docRef = db.collection(ClientCollection);
        const clientsSnapshot = await docRef.get();
        const clients = clientsSnapshot.docs.map(doc => { return doc.data(); })
        const clientsObj = { "clients": clients };
        response.json(clientsObj);
    });

    //Create client
    clientsServer.post('/client', async (request, response) => {
        const name = request.body["fullname"];
        const gender = request.body["gender"];
        const phone = request.body["phone"];
        const email = request.body["email"];
        const newClientId = uuid.v1();
        const docRef = db.collection(ClientCollection).doc(newClientId);
        const client = new Client(newClientId, name, gender, phone, email);
        await docRef.set(JSON.parse(JSON.stringify(client)));
        response.send(
            'Client with name ' + client.fullname + ' created!'
        );
    });

    //Delete client
    clientsServer.post('/client/delete/:id', async (request, response) => {
        await db.collection(ClientCollection).doc(request.params.id).delete();
        response.send(
            'Client with id ' + request.params.id + ' deleted!'
        );
    });

    return clientsServer;
}


