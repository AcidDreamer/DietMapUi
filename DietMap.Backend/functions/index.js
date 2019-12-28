const functions = require('firebase-functions');
const admin = require('firebase-admin');

admin.initializeApp(functions.config().firebase);
let db = admin.firestore();

const clientFactory = require('./clients-server');
const clientsServer = clientFactory.CreateClientServer(db);
const clientsApi = functions.https.onRequest((request, response) => {
    if (!request.path) {
      request.url = `/${request.url}`; // Prepend '/' to keep query params if any
    }
    return clientsServer(request, response);
  });
  
module.exports = {
  clientsApi
};
