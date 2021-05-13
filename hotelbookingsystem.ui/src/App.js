import React from 'react'; 
import './App.css'; 
import { store } from "./actions/store"; 
import { Provider } from "react-redux"; 
import Hotels from './components/Hotels'; 
import { Container } from "@material-ui/core"; 
import { ToastProvider } from "react-toast-notifications";
import { Link, BrowserRouter as Router, Route } from 'react-router-dom';
import HotelsForUsers from './components/HotelsForUsers';


function App() { 
  return ( 
    <Provider store={store}> 
    <ToastProvider autoDismiss={true}> 
      <Container maxWidth="lg"> 
        <HotelsForUsers /> 
      </Container> 
    </ToastProvider> 
  </Provider> 
  ); 
} 

export default App; 


