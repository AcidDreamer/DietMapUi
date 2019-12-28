const functions = require('firebase-functions');
const admin = require('firebase-admin');

admin.initializeApp();

const { clientApi } = require('./clients-server');

const clientsApi = functions.https.onRequest((request, response) => {
    if (!request.path) {
      request.url = `/${request.url}`; // Prepend '/' to keep query params if any
    }
  
    return clientsServer(request, response);
  });
  
module.exports = {
  clientApi
};
