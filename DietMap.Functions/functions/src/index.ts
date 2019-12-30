import * as functions from 'firebase-functions'
import * as admin from 'firebase-admin' ;
import { CreateClientServer } from './servers/ClientServer';

admin.initializeApp(functions.config().firebase);
const db = admin.firestore();

const clientsServer = CreateClientServer(db);
const clientsApi = functions.https.onRequest((request, response) => {
    if (!request.path) {
      request.url = `/${request.url}`;
    }
    return clientsServer(request, response);
  });
  
module.exports = {
  clientsApi
};
