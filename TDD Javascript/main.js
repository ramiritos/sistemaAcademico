// estadisticas.js
module.exports = {
    calcularMedia: (array) => {
      if (array.length === 0) {
        throw new Error('No se puede calcular la media de un array vacío');
      }
  
      if (!array.every(Number.isFinite)) {
        throw new Error('El array debe contener solo números');
      }
  
      return array.reduce((a, b) => a + b, 0) / array.length;
    },
  
    calcularDesviacionEstandar: (array) => {
      if (array.length === 0) {
        throw new Error('No se puede calcular la desviación estándar de un array vacío');
      }
  
      if (!array.every(Number.isFinite)) {
        throw new Error('El array debe contener solo números');
      }
  
      const mediaValor = this.calcularMedia(array);
      const sumaCuadrados = array.reduce((a, b) => a + Math.pow(b - mediaValor, 2), 0);
  
      return Math.sqrt(sumaCuadrados / array.length);
    },
  };
  
  
  // main.js
  const { calcularMedia, calcularDesviacionEstandar } = require('./estadisticas'); // Importa tus funciones desde estadisticas.js
  
  console.log(`Calculo de media: ${calcularMedia([1, 2, 3, 4, 5])}`);   
  
  console.log(`Calculo de desviación estandar: ${calcularDesviacionEstandar([1, 2, 3, 4, 5])}`);  
  
  
  
  // test.js
  
  const { calcularMedia, calcularDesviacionEstandar } = require('./estadisticas');
  
  describe('Calculo de Media y Desviación Estándar', () => {
  
    it('Deberia calcular la media de un array', () => {
      expect(calcularMedia([1, 2, 3, 4, 5])).toBe(3); // Prueba para calcular la media de un array
    });
  
    it('Deberia calcular la desviacion estandar de un array', () => { 
      const array = [1, 2, 3, 4, 5]; 
      expect(calcularDesviacionEstandar(array)).toBeCloseTo(1.41, 2); // Prueba para calcular la desviación estándar
    });
  
    it('Deberia lanzar error para media de array vacio', () => { 
      const array = []; 
      expect(() => calcularMedia(array)).toThrowError(
        'No se puede calcular la media de un array vacío'
      );
    });
  
    it('Deberia lanzar error para desviacion estandar de array vacio', () => { 
      const array = []; 
      expect(() => calcularDesviacionEstandar(array)).toThrowError(
        'No se puede calcular la desviación estándar de un array vacío'
      );
    });
  
    // Agregar más casos de prueba...
  });
  
  
  
  