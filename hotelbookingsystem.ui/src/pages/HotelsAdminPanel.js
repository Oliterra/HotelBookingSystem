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
/*import React, { useEffect, useState, useMemo } from "react";
import { connect } from "react-redux";
import * as actions from "../../actions/hotel";
import HeaderForHotelList from "./HeaderForHotelList";
import Pagination from "./Pagination";
import Search from "./Search";
import { withStyles} from "@material-ui/core";

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

const HotelsTable = ({ userId, classes, ...props }) => {
  const [hotels, setHotels] = useState([]);
  const [totalItems, setTotalItems] = useState(0);
  const [currentPage, setCurrentPage] = useState(1);
  const [search, setSearch] = useState("");
  const [sorting, setSorting] = useState({ field: "", order: "" });

  const ITEMS_PER_PAGE = 15;

  const headers = [
    { name: "Name", field: "name", sortable: true },
    { name: "Number of hotel stars", field: "starsNumber", sortable: true },
    { name: "Country", field: "Country", sortable: false },
    { name: "City", field: "city", sortable: false },
    { name: "Minimum price for the room", field: "nimRoomPrice", sortable: true },
    { name: "Address", field: "address", sortable: false },
  ];

  useEffect(() => {
    props.fetchAllHotels();
    setHotels(props.hotelList);
  }, []);

  const hotelsData = useMemo(() => {
    if (props.hotelList !== []) {
      let computedHotels = props.hotelList;

      if (search) {
        computedHotels = computedHotels.filter(
            query==="name" ? (hotel) => hotel.name.toLowerCase().includes(search.toLowerCase()) : (hotel) => hotel.amenities.toLowerCase().includes(search.toLowerCase())
        );
      }

      setTotalItems(computedHotels.length);

      //Sorting comments
      if (sorting.field) {
        const reversed = sorting.order === "asc" ? 1 : -1;
        computedHotels = computedHotels.sort(
          (a, b) => reversed * a[sorting.field].localeCompare(b[sorting.field])
        );
      }

      //Current Page slice
      return computedHotels.slice(
        (currentPage - 1) * ITEMS_PER_PAGE,
        (currentPage - 1) * ITEMS_PER_PAGE + ITEMS_PER_PAGE
      );
    }
  }, [hotel, currentPage, search, sorting, props.hotelList]);

  return (
    <>
      <div className="row w-100">
        <div className="col mb-3 col-12 text-center">
          <div className="row">
            <div className="col-md-8">
              <Pagination
                total={totalItems}
                itemsPerPage={ITEMS_PER_PAGE}
                currentPage={currentPage}
                onPageChange={(page) => setCurrentPage(page)}
              />
            </div>
            <div className="col-md-4 d-flex justify-content-between flex-row-reverse">
              <Search
                onSearch={(value) => {
                  setSearch(value);
                  setCurrentPage(1);
                }}
              />
              <select  style={{ width: "40%",  height: "70%" }} value={query} onChange={handleQueryChange} className="form-select" aria-label="Name">
                <option value="name">Name</option>
                <option value="amenities">Amenities</option>
              </select>
            </div>
        </div>

          <table className="table table-striped">
            <TableHeader
              headers={headers}
              onSorting={(field, order) => setSorting({ field, order })}
            />
            <TableBody> 
            { 
              props.hotelList.map((record, index) => { 
                  return (<TableRow key={index} hover> 
                  <TableCell>
                  <Grid container>{record.name}</Grid> 
                  <Grid container>{record.starsNumber}</Grid> 
                  <Grid container>{record.country}</Grid> 
                  <Grid container>{record.city}</Grid> 
                  <Grid container>{record.minRoomPrice}</Grid> 
                  <Grid container>{record.address}</Grid> 
                  </TableCell>
               </TableRow>) 
              }) 
            } 
            </TableBody> 
              </table>
            </div>
          </div>
        </>
      );
    };
    
    const mapStateToProps = (state) => ({
      hotelList: state.hotel.list,
    });
    
    const mapActionToProps = {
      fetchAllHotels: actions.fetchAll,
    };
    
  export default connect(mapStateToProps, mapActionToProps)(withStyles(styles)(HotelsTable));
   */
    
  /*import React, { useState, useEffect } from "react";
import { connect } from "react-redux";
import * as actions from "../actions/hotel";
import { Grid, Paper, withStyles,} from "@material-ui/core";
import HotelsTable from "./HotelsTable";
import HotelsForUsers from "./HotelsForUsers";

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

const HotelsForUsers2 = ({ classes, ...props }) => {
  const [currentId, setCurrentId] = useState(0);

  useEffect(() => {
    props.fetchAllHotels();
  }, []); 

  return (
    <Paper className={classes.paper} elevation={3}>
      <Grid container>
        <h1 className="display-4">Hotels</h1>
      </Grid>
      <Grid container>
        <Grid item xs={8}>
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

export default connect(mapStateToProps, mapActionToProps)(withStyles(styles)(HotelsForUsers2));
*/