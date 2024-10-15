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
