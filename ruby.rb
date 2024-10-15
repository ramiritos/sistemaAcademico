require 'mathn'

class Estadisticas
  # Método para calcular la media de una lista de números
  def calcular_media(lista)
    if lista.empty?
      raise ArgumentError, "La lista está vacía."
    end
    media = lista.sum.to_f / lista.size
    media
  end

  # Método para calcular la desviación estándar
  def calcular_desviacion_estandar(lista)
    if lista.empty?
      raise ArgumentError, "La lista está vacía."
    end
    media = calcular_media(lista)
    varianza = lista.map { |x| (x - media)**2 }.sum / lista.size.to_f
    Math.sqrt(varianza)
  end
end

# Pruebas manuales
estadisticas = Estadisticas.new

# Prueba para calcular la media
puts "Media de [1, 2, 3, 4, 5]: #{estadisticas.calcular_media([1, 2, 3, 4, 5])}" # Debería dar 3.0

# Prueba para calcular la desviación estándar
puts "Desviación estándar de [1, 2, 3, 4, 5]: #{estadisticas.calcular_desviacion_estandar([1, 2, 3, 4, 5])}" # Debería dar aproximadamente 1.41421
