import React, { useState, useEffect } from "react";
import { connect } from "react-redux";
import * as actions from "../actions/hotel";
import { Grid, Paper, withStyles,} from "@material-ui/core";
import HotelsTable from "./HotelsTable";
import "./HotelsForUsers.css";

const styles = (theme) => ({
  root: {
    "& .MuiTableCell-head": {
      fontSize: "1.25rem",
    },
  },
  paper: {
    margin: theme.spacing(2),
    padding: theme.spacing(2),
  },
});

const HotelsForUsers = ({ classes, ...props }) => {
  const [currentId, setCurrentId] = useState(0);

  useEffect(() => {
    props.fetchAllHotels();
  }, []); 

  return (
    <Paper className={classes.paper} elevation={4}>
      <Grid container>
        <h1 className="result">Here's what we can offer you:</h1>
      </Grid>
      <Grid container>
        <Grid item xs={7}>
          <HotelsTable userId={currentId => setCurrentId(currentId)} />
        </Grid>
      </Grid>
    </Paper>
  );
};

const mapStateToProps = (state) => ({
  hotelList: state.hotel.list,
});

const mapActionToProps = {
  fetchAllHotels: actions.fetchAll,
};

export default connect(mapStateToProps, mapActionToProps)(withStyles(styles)(HotelsForUsers))