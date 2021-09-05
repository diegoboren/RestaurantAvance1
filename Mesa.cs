    using System;
    namespace Proyecto
    {
        public class Mesa
        {
            int _cantidadOcupantes;
            string _zonaRestaurant;
            string _mozoAsignado;
            bool _estaOcupada;
            //double _totalCuenta;
            private int _numeroDeMesa;

            public Mesa()
            {
                NumeroDeMesa = 0;
                _cantidadOcupantes = 0;
                _zonaRestaurant = "";
                _mozoAsignado = "";
            }




            public int NumeroDeMesa { get => _numeroDeMesa; set => _numeroDeMesa = value; }

            public int CantidadOcupantes
            {
                get
                {
                    return _cantidadOcupantes;
                }


                set
                {
                    _cantidadOcupantes = value;
                }
            }



            public string ZonaRestaurant
            {
                get
                {
                    return _zonaRestaurant;
                }


                set
                {
                    _zonaRestaurant = value;
                }
            }



            public string MozoAsignado
            {
                get
                {
                    return _mozoAsignado;
                }


                set
                {
                    _mozoAsignado = value;
                }
            }


            public bool EstaOcupada
            {


                set
                {
                    if (NumeroDeMesa != 0 && CantidadOcupantes > 0)
                    {
                        _estaOcupada = true;

                    }
                    else
                    {
                        _estaOcupada = false;
                    }

                }

                get
                {
                    return _estaOcupada;

                }


            }


        }
    }
