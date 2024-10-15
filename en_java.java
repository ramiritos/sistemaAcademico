import org.junit.Test;
import static org.junit.Assert.*;
import java.util.Arrays;

public class Estadisticas {

    @Test
    public void testMedia() {
        int[] lista1 = {1, 2, 3, 4, 5};
        double resultado1 = calcularMedia(lista1);
        assertEquals(3.0, resultado1, 1e-9);

        // Testeo con una lista vacía
        try {
            calcularMedia(new int[0]);
            fail("La excepción no debería haberse producido");
        } catch (IllegalArgumentException e) {}

    }

    @Test
    public void testDesviacionEstandar() {
        int[] lista1 = {1, 2, 3, 4, 5};
        double resultado1 = calcularDesviacionEstandar(lista1);
        assertEquals(1.4142135623730951, resultado1, 1e-9);

        // Testeo con una lista vacía
        try {
            calcularDesviacionEstandar(new int[0]);
            fail("La excepción no debería haberse producido");
        } catch (IllegalArgumentException e) {}

    }

    public double calcularMedia(int[] lista) {
        if (lista == null || lista.length == 0) {
            throw new IllegalArgumentException("La lista está vacía.");
        }
        return Arrays.stream(lista).average().getAsDouble();
    }

    public double calcularDesviacionEstandar(int[] lista) {
        if (lista == null || lista.length == 0) {
            throw new IllegalArgumentException("La lista está vacía.");
        }
        double media = calcularMedia(lista);
        double varianza = Arrays.stream(lista).mapToDouble(element -> Math.pow(element - media, 2)).sum();
        return Math.sqrt(varianza / lista.length);  // Dividir por el número de elementos
    }
}
