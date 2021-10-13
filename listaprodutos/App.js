import React, {Component} from 'react';
import { SafeAreaView, Text, StyleSheet, FlatList, View} from 'react-native';
import api from './src/Services/Api';
import Produto from './src/Pages/Produto';

export default class App extends Component{

  constructor(props){
    super(props);
    this.state = {
      produtos: []
    }
  }

  async componentDidMount(){
    const response = await api.get('Produto/listagem');
    this.setState({
      produtos: response.data
    });
  }


  render(){
    return(
      <SafeAreaView style={styles.container}>
      <View style={styles.cabeçalho}>
        <Text style={styles.textoCabeçalho}>
          Lista de Produtos
        </Text>
        </View>
      <FlatList
        data={this.state.produtos}
        keyExtractor={item => item.Nome}
        renderItem={({item}) => <Produto data={item}/>}
      />
      </SafeAreaView>
    )
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#6495ED",
  },
  cabeçalho: {
    backgroundColor: '#4169E1', 
    marginTop: 35, 
    padding: 18, 
    borderRadius: 10
  },
  textoCabeçalho: {
    color: 'white',
     fontSize: 20,
      fontWeight: 'bold'
    }
});
