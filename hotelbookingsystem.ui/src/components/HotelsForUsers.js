import React, { useState, useEffect } from "react"; 
import { connect } from "react-redux"; 
import * as actions from "../actions/hotel"; 
import { Grid, Paper, TableContainer, Table, TableRow, TableCell, TableBody, withStyles } from "@material-ui/core"; 
import './HotelsForUsers.css';


const styles = theme => ({ 
    root: { 
        "& .MuiTableCell-head": { 
            fontSize: "1rem"
        } 
    }, 

    paper: { 
        margin: theme.spacing(2), 
        padding: theme.spacing(2), 
    } 
}) 

const HotelsForUsers = ({ classes, ...props }) => { 
    const [currentId, setCurrentId] = useState(0) 

    useEffect(() => { 
        props.fetchAllHotels() 
    }, [props]) 

    return ( 
        <Paper className={classes.paper} elevation={5}> 
             <Grid container>  
                 <Grid item xs={12}> 
                     <TableContainer> 
                         <Table> 
                             <TableBody> 
                                 { 
                                     props.hotelList.map((record, index) => { 
                                         return (<TableRow key={index} hover> 
                                         <TableCell>
                                             <Grid container className='name'>{record.name}</Grid> 
                                             <Grid container>{record.starsCount}</Grid> 
                                             <Grid container>{record.country}</Grid> 
                                             <Grid container>{record.city}</Grid> 
                                             <Grid container>{record.priceFrom}</Grid> 
                                             <Grid container>{record.priceTo}</Grid> 
                                             <Grid container>{record.address}</Grid> 
                                             </TableCell>
                                        </TableRow>) 
                                     }) 
                                 } 
                             </TableBody> 
                         </Table> 
                    </TableContainer> 
                 </Grid> 
             </Grid> 
         </Paper> 
     );  }

const mapStateToProps = state => ({ 
    hotelList: state.hotel.list 
}) 

const mapActionToProps = { 
    fetchAllHotels: actions.fetchAll, 
} 

export default connect(mapStateToProps, mapActionToProps)(withStyles(styles)(HotelsForUsers)); 