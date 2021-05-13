import React from 'react'; 
import './App.css'; 
import { store } from "./actions/store"; 
import { Provider } from "react-redux"; 
import Hotels from './components/Hotels'; 
import { Container } from "@material-ui/core"; 
import { ToastProvider } from "react-toast-notifications";
import { Link, Switch, BrowserRouter as Router, Route } from 'react-router-dom';
import HotelsForUsers from './components/HotelsForUsers';
import Header from "./components/Header";
import Footer from "./components/Footer";

function App() { 
  return ( 
    <div>

      <div>
        <Header />
      </div>

      <div>
         <Provider store={store}> 
           <ToastProvider autoDismiss={true}> 
             <Container maxWidth="lg"> 
               <HotelsForUsers /> 
             </Container> 
           </ToastProvider> 
         </Provider> 
      </div>
      
      <div>
        <Footer />
      </div>

    </div>
  ); 
} 

export default App; 


