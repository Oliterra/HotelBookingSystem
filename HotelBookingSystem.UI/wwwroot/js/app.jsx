class Hello extends React.Component {
    render() {
        return <h1>Привет, React.JS</h1>;
    }
}
ReactDOM.render( //renders a component on a web page in an element with id= "content"
    <Hello />,
    document.getElementById("content") 
);