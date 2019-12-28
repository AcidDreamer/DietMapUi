const cors = require('cors');
const express = require('express');
const functions = require('firebase-functions');

const clientsServer = express();
clientsServer.use(cors({origin: true}));
clientsServer.get('/clients', (request, response) => {
  response.send(
    'Hello from Express on Firebase with CORS! No trailing \'/\' required!'
  );
});


module.exports = {
    clientsApi
  };
  