// main.js
const { calcularMedia, calcularDesviacionEstandar } = require('./estadisticas'); // Importa tus funciones desde estadisticas.js

console.log(`Calculo de media: ${calcularMedia([1, 2, 3, 4, 5])}`);   

console.log(`Calculo de desviación estandar: ${calcularDesviacionEstandar([1, 2, 3, 4, 5])}`);