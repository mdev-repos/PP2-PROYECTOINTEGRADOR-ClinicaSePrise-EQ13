namespace ClinicaSePriseApp.Datos
{
    /// <summary>
    /// Wrapper simple para una lista fija (read-only) con utilidades de selección.
    /// </summary>
    internal sealed class FixedList<T>
    {
        private readonly List<T> _items;

        public FixedList(IEnumerable<T> items)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            _items = new List<T>(items);
        }

        public IReadOnlyList<T> Items => _items.AsReadOnly();

        public int Count => _items.Count;

        public T? SelectByIndex(int index)
            => (index >= 0 && index < _items.Count) ? _items[index] : default;

        public T? SelectFirst(Func<T, bool> predicate)
            => _items.FirstOrDefault(predicate);

        public IEnumerable<T> Where(Func<T, bool> predicate)
            => _items.Where(predicate);

        public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();
    }

    internal static class Listas
    {
        public static readonly FixedList<string> Roles =
            new FixedList<string>([ "Administrador", "Profesional" ]);

        public static readonly FixedList<string> Sexos =
            new FixedList<string>([ "Masculino", "Femenino" ]);

        public static readonly FixedList<string> Especialidad =
            new FixedList<string>(["Pediatría",
                                                 "Geriatría",
                                                 "Ginecología y Obstetricia",
                                                 "Cardiología",
                                                 "Dermatología",
                                                 "Clínica Médica",
                                                 "Traumatología",
                                                 "Oftalmología",
                                                 "Neurología",
                                                 "Urología" 
            ]);

        public static readonly FixedList<string> ObraSocial =
            new FixedList<string>(["Salud Total",
                                                 "Prevenir Salud",
                                                 "Medicina Activa",
                                                 "O.S.P.E.",
                                                 "Unión Médica",
                                                 "Plan Integral",
                                                 "Asegurar Vida",
                                                 "Cobertura Azul",
                                                 "O.S.M.A.",
                                                 "Sancor Salud",
                                                 "Swiss Medical",
                                                 "Galeno",
                                                 "O.S.D.E.",
                                                 "Prevención Médica",
                                                 "Consultar Ahora",
                                                 "Bienestar Total",
                                                 "Red de Sanación",
                                                 "O.S.P.I.L.",
                                                 "Grupo Médico Sur",
                                                 "Servicio Superior"
            ]);
    }
}