import React from "react";
import {NavLink} from "react-router-dom";
import "./Header.css";
import HomeWork from "@material-ui/icons/HomeWork"; 
import HotelIcon from '@material-ui/icons/Hotel';

function Header(){
    return(
    <header className='header'>
        <div className='container'>
          <HomeWork style={{ color: "white" , fontSize: 40, margin: "3%"}}/><h1>Сonvenient booking</h1> <HotelIcon style={{ color: "white" , fontSize: 40, margin: "3%"}} />
        </div>
    </header>
    );
}
export default Header;

