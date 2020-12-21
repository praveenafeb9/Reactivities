import React, { Component } from 'react';

import './App.css';
import axios from 'axios';
import { Header, Icon, Image, List } from 'semantic-ui-react'

class App extends Component {
    state = {
        values:[]
    }

    componentDidMount() {
        axios.get('http://localhost:5000/api/values').then((response) => {
            
            this.setState({
                values: response.data
            })
        })
        //this.setState(
        //    {
        //        values: [{ id: 1, name: 'value 101' }, { id: 2, name: 'value 102' }, {id:3, name:'value 103'}]
                
        //    })
    
    }
    render()
    {
        
        return (
           
            <div>
                
                <Header as='h2'>
                    <Icon name='users' circular/>
                    <Header.Content> Reactivities </Header.Content>                    
                </Header>
                
                <List>
                    {
                        this.state.values.map((rec: any) => (
                            <List.Item key={rec.id}> {rec.name} </List.Item>
                        ))
                        }
                </List>
                    

                
            </div>
        );
    }
    
}

export default App;
