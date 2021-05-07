function HotelData(props) {

    const {hotels} = props

    if (!hotels || hotels.length === 0) return <p>No hotels</p> //делаем проверку, есть ли данные с сервера
}

return (
<div>
    <table>
        <thead>
            <tr>
                <th>id</th>
                <th>name</th>
                <th>starsCount</th>
                <th>country</th>
                <th>city</th>
                <th>priceFrom</th>
                <th>priceTo</th>
                <th>address</th>
            </tr>
        </thead>
        <tbody>
            {
                hotels.map((hotel) => // Методом map проходим по массиву, для каждого отеля создаем строку
                    <tr key={person.id}>
                        <td>{hotel.id}</td>
                        <td>{hotel.name}</td>
                        <td>{hotel.starsCount}</td>
                        <td>{hotel.country}</td>
                        <td>{hotel.city}</td>
                        <td>{hotel.priceFrom}</td>
                        <td>{hotel.priceTo}</td>
                        <td>{hotel.address}</td>
                    </tr>
                )
            }
        </tbody>
    </table>
</div>)

export default Hoteldata
    

