import React, { useEffect, useState, useMemo } from "react";
import { connect } from "react-redux";
import * as actions from "../actions/hotel";
import SortingOptions from "./SortingOptions";
import Pagination from "./Pagination";
import Search from "./Search";
import { Grid, Paper, withStyles, TableBody, TableRow, TableCell} from "@material-ui/core";
import StarRateIcon from '@material-ui/icons/StarRate';
import "./HotelsTable.css";

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
  const [hotel, setHotels] = useState([]);
  const [totalItems, setTotalItems] = useState(0);
  const [currentPage, setCurrentPage] = useState(1);
  const [search, setSearch] = useState("");
  const [sorting, setSorting] = useState({ field: "", order: "" });

  const ITEMS_PER_PAGE = 10;

  const options = [
    { name: "Name", field: "name", sortable: true },
    { name: "Rating", field: "starsNumber", sortable: true },
    { name: "Price", field: "minRoomPrice", sortable: true },
  ];

  useEffect(() => {
    props.fetchAllHotels();
    setHotels(props.hotelList);
  }, []);

  const hotelsTable = useMemo(() => {
    if (props.hotelList !== []) {
      let computedHotels = props.hotelList;

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
        <div className="search">
              <Search
                onSearch={(value) => {
                  setSearch(value);
                  setCurrentPage(1);
                }}
              />
        </div>

        <div className="sortings">
        <table>
            <SortingOptions
              options={options}
              onSorting={(field, order) => setSorting({ field, order })}
            />
        </table>
        </div>

        <div className="hotels">
          { 
            props.hotelList.map((record, index) => { 
              return (<TableRow className = "row"> 
                <Grid container className="cell">
                <Grid container className="name">{record.name}<StarRateIcon />{record.starsNumber}</Grid> 
                <Grid container className = "address">{record.address}</Grid> 
                <Grid container>{record.country}</Grid> 
                <Grid container>{record.city}</Grid> 
                <Grid container>{record.minRoomPrice}</Grid> 
                </Grid>
              </TableRow>) 
              }) 
          } 
        </div> 

        <div className="pagination">
          <Pagination
            total={totalItems}
            itemsPerPage={ITEMS_PER_PAGE}
            currentPage={currentPage}
            onPageChange={(page) => setCurrentPage(page)}
          />
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