function Hotels() {
  
  const [appState, setAppState] = useState();
  
  useEffect(() => {
    const apiUrl = 'https://localhost:5000/api/HotelSearch';
    axios.get(apiUrl).then((resp) => {
      const allHotels = resp.data;
      setAppState(allPersons);
    });
  }, [setAppState]);

 
  return (
    <div className="hotels">
    
    </div>
  );
}

export default Hotels;