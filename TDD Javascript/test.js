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
