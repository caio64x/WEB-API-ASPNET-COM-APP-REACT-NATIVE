import axios from 'axios';

const api = axios.create({
    baseURL: 'https://meusite.conveyor.cloud/'
});
export default api;