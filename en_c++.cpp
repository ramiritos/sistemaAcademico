#include <iostream>
#include <cmath>
using namespace std;

double calcularMedia(double notas[], int tamanoNotas) {
    double suma = 0;
    for (int i = 0; i < tamanoNotas; i++) {
        suma += notas[i];
    }
    return suma / tamanoNotas;
}

double calcularDesviacionEstandar(double notas[], int tamanoNotas) {
    double media = calcularMedia(notas, tamanoNotas);
    double sumaDiferencias = 0;
    for (int i = 0; i < tamanoNotas; i++) {
        sumaDiferencias += (notas[i] - media) * (notas[i] - media);
    }
    return sqrt(sumaDiferencias / tamanoNotas);
}

int main() {
    const int tamanoNotas = 3;
    char nombre[50];
    double notas[tamanoNotas];

    cout << "Bienvenido, por favor ingresa tu nombre: ";
    cin >> nombre;

    for (int i = 0; i < tamanoNotas; i++) {
        cout << "Ingrese la nota " << i + 1 << ": ";
        cin >> notas[i];
    }

    double mediaNota = calcularMedia(notas, tamanoNotas);
    double desviacionEstandar = calcularDesviacionEstandar(notas, tamanoNotas);

    cout << "La media es: " << mediaNota << endl;
    cout << "La desviación estándar es: " << desviacionEstandar << endl;

    return 0;
}