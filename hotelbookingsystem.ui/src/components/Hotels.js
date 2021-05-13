import React, { useState, useEffect } from "react"; 
import { connect } from "react-redux"; 
import * as actions from "../actions/hotel"; 
import { Grid, Paper, TableContainer, Table, TableHead, TableRow, TableCell, TableBody, withStyles, ButtonGroup, Button } from "@material-ui/core"; 
import HotelForm from "./HotelForm"; 
import EditIcon from "@material-ui/icons/Edit"; 
import DeleteIcon from "@material-ui/icons/Delete"; 
import { useToasts } from "react-toast-notifications"; 

const styles = theme => ({ 
    root: { 
        "& .MuiTableCell-head": { 
            fontSize: "1rem"
        } 
    }, 

    paper: { 
        margin: theme.spacing(2), 
        padding: theme.spacing(2) 
    } 
}) 

const Hotels = ({ classes, ...props }) => { 
    const [currentId, setCurrentId] = useState(0) 

    useEffect(() => { 
        props.fetchAllHotels() 
    }, [props]) 

    const { addToast } = useToasts() 

    const onDelete = id => { 
      if (window.confirm('Are you sure to delete this record?')) 
            props.deleteHotel(id,()=>addToast("Deleted successfully", { appearance: 'info' })) 
    } 

    return ( 
        <Paper className={classes.paper} elevation={3}> 
            <Grid container> 
                <Grid item xs={12}> 
                    <HotelForm {...({ currentId, setCurrentId })} /> 
                </Grid> 
                <Grid item xs={12}> 
                    <TableContainer> 
                        <Table> 
                            <TableBody> 
                                { 
                                    props.hotelList.map((record, index) => { 
                                        return (<TableRow key={index} hover> 
                                            <TableCell>{record.name}</TableCell> 
                                            <TableCell>{record.starsNumber}</TableCell> 
                                            <TableCell>{record.country}</TableCell> 
                                            <TableCell>{record.city}</TableCell> 
                                            <TableCell>{record.minRoomPrice}</TableCell> 
                                            <TableCell>{record.address}</TableCell> 
                                            <TableCell> 
                                                <ButtonGroup variant="text"> 
                                                    <Button><EditIcon color="primary" 
                                                        onClick={() => { setCurrentId(record.id) }} /></Button> 
                                                    <Button><DeleteIcon color="secondary" 
                                                        onClick={() => onDelete(record.id)} /></Button> 
                                                </ButtonGroup> 
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
    ); 
} 

const mapStateToProps = state => ({ 
    hotelList: state.hotel.list 
}) 

const mapActionToProps = { 
    fetchAllHotels: actions.fetchAll, 
    deleteHotel: actions.Delete 
} 

export default connect(mapStateToProps, mapActionToProps)(withStyles(styles)(Hotels)); 