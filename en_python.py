import unittest
import math

# Funciones que calculan la media y la desviación estándar
def calcularMedia(lista):
    if not lista:
        raise ValueError("La lista está vacía.")
    return sum(lista) / len(lista)

def calcularDesviacionEstandar(lista):
    if not lista:
        raise ValueError("La lista está vacía.")
    media = calcularMedia(lista)
    varianza = sum((x - media) ** 2 for x in lista) / len(lista)
    return math.sqrt(varianza)

# Clase de pruebas usando unittest
class TestEstadisticas(unittest.TestCase):
    def test_media(self):
        self.assertEqual(calcularMedia([1, 2, 3, 4, 5]), 3.0)
        self.assertEqual(calcularMedia([0, 0, 0]), 0.0)
        self.assertEqual(calcularMedia([1.5, 2.5, 3.5]), 2.5)

    def test_desviacion_estandar(self):
        self.assertAlmostEqual(calcularDesviacionEstandar([1, 2, 3, 4, 5]), 1.4142, places=4)
        self.assertEqual(calcularDesviacionEstandar([0, 0, 0]), 0.0)
        self.assertAlmostEqual(calcularDesviacionEstandar([1.5, 2.5, 3.5]), 0.8165, places=4)

    def test_invalid_input(self):
        with self.assertRaises(ValueError):
            calcularMedia([])
        with self.assertRaises(ValueError):
            calcularDesviacionEstandar([])

if __name__ == '__main__':
    unittest.main()
