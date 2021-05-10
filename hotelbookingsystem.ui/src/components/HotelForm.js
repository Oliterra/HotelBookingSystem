import React, { useState, useEffect } from "react"; 
import { Grid, TextField, withStyles, FormControl, InputLabel, Select, MenuItem, Button, FormHelperText } from "@material-ui/core"; 
import useForm from "./useForm.js"; 
import { connect } from "react-redux"; 
import * as actions from "../actions/hotel"; 
import { useToasts } from "react-toast-notifications"; 


const styles = theme => ({ 
    root: { 
        '& .MuiTextField-root': { 
            margin: theme.spacing(1), 
            minWidth: 230, 
        } 
    }, 

    formControl: { 
        margin: theme.spacing(1), 
        minWidth: 230, 
    }, 
    smMargin: { 
        margin: theme.spacing(1) 
    } 
}) 

const initialFieldValues = { 
    name: '', 
    starsCount: '', 
    country: '', 
    city: '', 
    priceFrom: '', 
    priceTo: '', 
    address: '' 
} 

const HotelForm = ({ classes, ...props }) => { 
    const { addToast } = useToasts() 

    const validate = (fieldValues = values) => { 

        let temp = { ...errors } 

        if ('name' in fieldValues) 
            temp.fullName = fieldValues.fullName ? "" : "This field is required." 
        if ('starsCount' in fieldValues) 
            temp.mobile = fieldValues.mobile ? "" : "This field is required." 
        if ('country' in fieldValues) 
            temp.bloodGroup = fieldValues.bloodGroup ? "" : "This field is required." 
        if ('city' in fieldValues) 
            temp.bloodGroup = fieldValues.bloodGroup ? "" : "This field is required." 
        if ('address' in fieldValues) 
            temp.bloodGroup = fieldValues.bloodGroup ? "" : "This field is required." 
        setErrors({ 
            ...temp 
        }) 

        if (fieldValues == values) 
            return Object.values(temp).every(x => x == "") 
    } 

    const { 
        values, 
        setValues, 
        errors, 
        setErrors, 
        handleInputChange, 
        resetForm 
    } = useForm(initialFieldValues, validate, props.setCurrentId) 

    const inputLabel = React.useRef(null); 

    const [labelWidth, setLabelWidth] = React.useState(0); 

    React.useEffect(() => { 
        setLabelWidth(inputLabel.current.offsetWidth); 
    }, []); 

    const handleSubmit = e => { 
        e.preventDefault() 
        if (validate()) { 
            const onSuccess = () => { 
                resetForm() 
                addToast("Submitted successfully", { appearance: 'success' }) 
            } 
            if (props.currentId == 0) 
                props.createHotel(values, onSuccess) 
            else 
               props.updateHotel(props.currentId, values, onSuccess) 
        } 
    } 
    useEffect(() => { 
        if (props.currentId != 0) { 
            setValues({ 

                ...props.hotelList.find(x => x.id == props.currentId) 
            }) 
            setErrors({}) 
        } 
    }, [props.currentId]) 

    return ( 
        <form autoComplete="off" noValidate className={classes.root} onSubmit={handleSubmit}> 
            <Grid container direction="column" justify="flex-start" alignItems="stretch"> 
                <Grid item xs={12} >
                <TextField 
                        name="name" 
                        variant="outlined" 
                        label="Name" 
                        value={values.name} 
                        onChange={handleInputChange} 
                        {...(errors.name && { error: true, helperText: errors.name })} 
                    />  
                    <TextField 
                        name="name" 
                        variant="outlined" 
                        label="Name" 
                        value={values.name} 
                        onChange={handleInputChange} 
                        {...(errors.name && { error: true, helperText: errors.name })} 
                    /> 
                    <FormControl variant="outlined" 
                        className={classes.formControl} 
                        {...(errors.starsCount && { error: true })} 
                    > 
                        <InputLabel ref={inputLabel}>Count of stars</InputLabel> 
                        <Select 
                            name="starsCount" 
                            value={values.starsCount} 
                            onChange={handleInputChange} 
                            labelWidth={labelWidth} 
                        > 
                            <MenuItem value="">Select number of stars</MenuItem> 
                            <MenuItem value="1">1</MenuItem> 
                            <MenuItem value="2">2</MenuItem> 
                            <MenuItem value="3">3</MenuItem> 
                            <MenuItem value="4">4</MenuItem> 
                            <MenuItem value="5">5</MenuItem> 
                        </Select> 
                        {errors.starsCount && <FormHelperText>{errors.starsCount}</FormHelperText>} 
                    </FormControl> 
                    <TextField 
                        name="country" 
                        variant="outlined" 
                        label="Country" 
                        value={values.country} 
                        onChange={handleInputChange} 
                        {...(errors.country && { error: true, helperText: errors.country })} 
                    /> 
                    <TextField 
                        name="city" 
                        variant="outlined" 
                        label="City" 
                        value={values.city} 
                        onChange={handleInputChange} 
                        {...(errors.city && { error: true, helperText: errors.city })} 
                    /> 
                    <TextField 
                        name="priceFrom" 
                        variant="outlined" 
                        label="Price from" 
                        value={values.priceFrom} 
                        onChange={handleInputChange} 
                    /> 
                    <TextField 
                        name="priceTo" 
                        variant="outlined" 
                        label="Price to" 
                        value={values.priceTo} 
                        onChange={handleInputChange} 
                    /> 
                    <TextField 
                        name="address" 
                        variant="outlined" 
                        label="Address" 
                        value={values.address} 
                        onChange={handleInputChange} 
                        {...(errors.address && { error: true, helperText: errors.address })} 
                    /> 
                    <div> 
                        <Button 
                            variant="contained" 
                            color="primary" 
                            type="submit" 
                            className={classes.smMargin} 
                        > 
                            Submit 
                        </Button> 

                        <Button 
                            variant="contained" 
                            color="secondary" 
                            className={classes.smMargin} 
                            onClick={resetForm} 
                        > 
                            Reset 
                        </Button> 
                    </div> 
                </Grid> 
            </Grid> 
        </form> 
    ); 
} 

const mapStateToProps = state => ({ 
    hotelList: state.hotel.list 
}) 

const mapActionToProps = { 
    createHotel: actions.create, 
    updateHotel: actions.update 
} 

export default connect(mapStateToProps, mapActionToProps)(withStyles(styles)(HotelForm)); 