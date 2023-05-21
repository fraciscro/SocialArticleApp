// Import the functions you need from the SDKs you need
import { initializeApp } from "firebase/app";
import { getAuth, GoogleAuthProvider } from "firebase/auth";
// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
const firebaseConfig = {
  apiKey: "AIzaSyCd2Y2Wq7KtmkEuUyPLsZsWlJ-zqkZuewE",
  authDomain: "socialarticleapp.firebaseapp.com",
  projectId: "socialarticleapp",
  storageBucket: "socialarticleapp.appspot.com",
  messagingSenderId: "1060630513952",
  appId: "1:1060630513952:web:9dd7b9d4d094a8f9f9ef45",
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);

export const auth = getAuth(app);
export const provider = new GoogleAuthProvider();
