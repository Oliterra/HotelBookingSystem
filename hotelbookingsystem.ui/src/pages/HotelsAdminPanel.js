import React from 'react'; 
import { store } from "./actions/store"; 
import { Provider } from "react-redux"; 
import Hotels from './components/Hotels'; 
import { Container } from "@material-ui/core"; 
import { ToastProvider } from "react-toast-notifications";

const HotelsAdminPanel = () => {
  return ( 
    <Provider store={store}> 
      <ToastProvider autoDismiss={true}> 
        <Container maxWidth="lg"> 
          <Hotels /> 
        </Container> 
      </ToastProvider> 
    </Provider> 
  ); 
} 
export default HotelsAdminPanel; 