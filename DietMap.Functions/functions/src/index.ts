// const dbUrl = "https://dietmap-c519e.firebaseio.com";
import * as functions from 'firebase-functions';
import * as admin from 'firebase-admin';
import * as express from 'express';
import * as bodyParser from "body-parser";
import './classes/Client';

admin.initializeApp();

const db = admin.firestore();
const app = express();
const main = express();
const clientsCollection = '/clients';

main.use('/api/v1', app);
main.use(bodyParser.json());
main.use(bodyParser.urlencoded({ extended: false }));
// webApi is your functions name, and you will pass main as 
// a parameter
export const webApi = functions.https.onRequest(main);
app.post('/client', async (req, res) => {
    try {
        const client = new Client(req.body['fullname']);
        functions.https.onRequest(async (req, res) => {
            const snapshot = await admin.database().ref(clientsCollection).push(client);
            res.status(201).send(`Created a new client: ${snapshot.key}`);
        });
    } catch (error) {
        res.status(400).send(`Cannot create client: ${error}`)
    }        
})
// // Update new client
// app.patch('/client/:clientId', async (req, res) => {
//     const updatedDoc = await firebaseHelper.firestore
//         .updateDocument(db, clientsCollection, req.params.clientId, req.body);
//     res.status(204).send(`Update a new client: ${updatedDoc}`);
// })
// // View a client
// app.get('/client/:clientId', (req, res) => {
//     firebaseHelper.firestore
//         .getDocument(db, clientsCollection, req.params.clientId)
//         .then((doc: any) => res.status(200).send(doc))
//         .catch((error: any) => res.status(400).send(`Cannot get client: ${error}`));
// })
// View all clients
app.get('/client', (req, res) => {
    functions.https.onRequest(async (req, res) => {
        await db.collection(clientsCollection).get().then(sp => {
            let array = sp.docs.map(doc => {
                return doc.data(); 
            });
            res.json(array);
        })
    });
})
// Delete a contact 
// app.delete('/client/:clientId', async (req, res) => {
//     const deletedClient = await firebaseHelper.firestore
//         .deleteDocument(db, clientsCollection, req.params.clientId);
//     res.status(204).send(`client is deleted: ${deletedClient}`);
// })
