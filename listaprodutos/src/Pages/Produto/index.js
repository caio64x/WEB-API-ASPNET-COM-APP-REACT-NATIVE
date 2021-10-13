import React, {Component} from 'react';
import {View, Text, StyleSheet, SafeAreaView} from 'react-native';
import styles from "../Produto/style.js";
export default class Produto extends Component{
    render(){
        return(
            <SafeAreaView style={{flex:1}}>
                    <View style={styles.container}>
                        <View style={styles.borda}>
                        
                            <Text style={styles.textheader}>ID:{' '}
                            <Text style={styles.dadosBanco}>{this.props.data.ID}</Text>
                            </Text>
                            
                            <Text style={styles.textheader}>ID Categoria:{' '}
                            <Text style={styles.dadosBanco}>{this.props.data.IDCategoria}</Text>
                            </Text>
                            
                            <Text style={styles.textheader}>Descrição:{' '}
                            <Text style={styles.dadosBanco}>{this.props.data.Nome}</Text>
                            </Text>
                            
                            <Text style={styles.textheader}>Marca:{' '}
                            <Text style={styles.dadosBanco}>{this.props.data.Marca}</Text>
                            </Text>
                           
                            <Text style={styles.textheader}>Quantidade:{' '}
                            <Text style={styles.dadosBanco}>{this.props.data.Quantidade}</Text>
                            </Text>
                            
                            <Text style={styles.textheader}>Valor Unitário:{' '}
                            <Text style={styles.dadosBanco}>{this.props.data.ValorUnitario}</Text>
                            </Text>

                            <Text style={styles.textheader}>Valor Total:{' '}
                            <Text style={styles.dadosBanco}>{this.props.data.ValorTotal}</Text>
                            </Text>
                        </View>
                    </View>
                        </SafeAreaView>
        );
    }
}

