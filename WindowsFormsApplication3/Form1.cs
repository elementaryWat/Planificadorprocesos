﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
   
    public partial class Form1 : Form
    {
        Queue EjecucionFlujo = new Queue();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        bool[] exProceso;
        int[] pend1CPU;
        int[] pendentrada;
        int[] pend2CPU;
        int[] pendsalida;
        int[] pend3CPU;
        int politica;
        int politicaES;

        const int FCFS = 1;
        const int SJF = 2;
        const int SRTF =3;
        private void inicializar(int cantidad)
        {
            //Lista de arreglos con las rafagas de los procesos
            List<int[]> configuraciones = new List<int[]>();
            exProceso = new bool[cantidad];
            pend1CPU = new int[cantidad];
            pendentrada = new int[cantidad];
            pend2CPU = new int[cantidad];
            pendsalida = new int[cantidad];
            pend3CPU = new int[cantidad];
            for (int x = 0; x < cantidad; x++)
            {
                exProceso[x] = false;
                pend1CPU[x] = (Int32.Parse(DatosFlow.Rows[x].Cells[2].Value.ToString()));
                pendentrada[x] = (Int32.Parse(DatosFlow.Rows[x].Cells[3].Value.ToString()));
                pend2CPU[x] = (Int32.Parse(DatosFlow.Rows[x].Cells[4].Value.ToString()));
                pendsalida[x] = (Int32.Parse(DatosFlow.Rows[x].Cells[5].Value.ToString()));
                pend3CPU[x] = (Int32.Parse(DatosFlow.Rows[x].Cells[6].Value.ToString()));
            }
            configuraciones.Add(pend1CPU);
            configuraciones.Add(pendentrada);
            configuraciones.Add(pend2CPU);
            configuraciones.Add(pendsalida);
            configuraciones.Add(pend3CPU);
            ordenador = new Computador(cantidad,configuraciones.ToArray());
        }
        private bool haynoarribados()
        {
            int cantidad = (DatosFlow.RowCount) - 1;
            for (int x=0;x<cantidad;x++)
            {
                if (!exProceso[x])
                {
                    return true;
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DatosFlow.Rows.Clear();
            //{Id_Proceso,Tiempo_de_arribo,1er_R_CPU,Entrada,2da_R_CPU,Salida,3er_R_CPU}
            string[] row1 = { "1", "0", "1", "3", "4", "3", "1" };
            DatosFlow.Rows.Add(row1);
            string[] row2 = { "2", "3", "1", "2", "3", "2", "1" };
            DatosFlow.Rows.Add(row2);
            string[] row3 = { "3", "5", "1", "3", "2", "1", "1" };
            DatosFlow.Rows.Add(row3);
            string[] row4 = { "4", "8", "1", "2", "4", "3", "1" };
            DatosFlow.Rows.Add(row4);
            string[] row5 = { "5", "10", "1", "4", "5", "3", "1" };
            DatosFlow.Rows.Add(row5);
            string[] row6 = { "6", "11", "1", "2", "2", "2", "1" };
            DatosFlow.Rows.Add(row6);
        }
        //Determina si hay un proceso
        int cantidad;
        public int[] verificaraarribar(int instante)
        {
            bool ninguno = true;
            int cantidada = 0;
            List<int> respuesta=new List<int>();
            cantidad = (DatosFlow.RowCount) - 1;
            for (int x = 0; x < cantidad; x++)
            {
                int arribo = (Int32.Parse(DatosFlow.Rows[x].Cells[1].Value.ToString()));
                if (!exProceso[x])
                {
                    if (arribo == instante)
                    {
                        exProceso[x] = true;
                        respuesta.Add(x);
                        ninguno = false;
                        cantidada++;
                    }
                    
                }
            }
            if (ninguno)
            {
                respuesta.Add(-1);
                return  respuesta.ToArray();
            }
            else
            {
                //MessageBox.Show("En el instante "+instante+" arriban "+cantidada+" procesos");
                return respuesta.ToArray();
            }
            
        }
        Computador ordenador;
        private bool notermi()
        {
            if (!haynoarribados())
            {
                if (ordenador.noterminado())
                {
                    return true;
                }
                return false;
            }
            else
            {
                return true;
            }
        }
        int reloj;
        private void imprimirestadisticas()
        {
            estadisticasEjec.Rows.Clear();
            Estadisticaspromedio.Rows.Clear();
            estadisticasEjecE.Rows.Clear();
            EstadisticaspromedioE.Rows.Clear();
            estadisticasEjecS.Rows.Clear();
            EstadisticaspromedioS.Rows.Clear();
            int[] tiemposretorno=new int[cantidad];
            int[] tiemposirrupcion = new int[cantidad];
            int[] tiemposarribo = new int[cantidad];
            int[] tiemposespera = new int[cantidad];
            int[] tiemposfinalizacion = new int[cantidad];
            int[] tiemposprimerrespuesta = new int[cantidad];
            int[] tiemposrespuesta = new int[cantidad];
            int sumaretorno = 0;
            int promretorno = 0;
            int sumarespuesta = 0;
            int promrespuesta = 0;
            int sumarespera = 0;
            int promespera = 0;
            //Obtiene estadiscticas de ordenador
            tiemposfinalizacion = ordenador.tiemposfinalizacion;
            tiemposprimerrespuesta = ordenador.tiemposprimerrespuesta;

            int[] tiemposarriboE = new int[cantidad];
            int[] tiemposretornoE = new int[cantidad];
            int[] tiemposirrupcionE = new int[cantidad];
            int[] tiemposesperaE = new int[cantidad];
            int[] tiemposfinalizacionE = new int[cantidad];
            int[] tiemposprimerrespuestaE = new int[cantidad];
            int[] tiemposrespuestaE = new int[cantidad];
            int sumaretornoE = 0;
            int promretornoE = 0;
            int sumarespuestaE = 0;
            int promrespuestaE = 0;
            int sumaresperaE = 0;
            int promesperaE = 0;
            //Obtiene estadiscticas de ordenador
            tiemposfinalizacionE = ordenador.tiemposfinalizacionE;
            tiemposprimerrespuestaE = ordenador.tiemposprimerrespuestaE;
            tiemposarriboE = ordenador.tiemposarriboE;

            int[] tiemposarriboS = new int[cantidad];
            int[] tiemposretornoS = new int[cantidad];
            int[] tiemposirrupcionS = new int[cantidad];
            int[] tiemposesperaS = new int[cantidad];
            int[] tiemposfinalizacionS = new int[cantidad];
            int[] tiemposprimerrespuestaS = new int[cantidad];
            int[] tiemposrespuestaS = new int[cantidad];
            int sumaretornoS = 0;
            int promretornoS = 0;
            int sumarespuestaS = 0;
            int promrespuestaS = 0;
            int sumaresperaS = 0;
            int promesperaS = 0;
            //Obtiene estadisticas de ordenador
            tiemposfinalizacionS = ordenador.tiemposfinalizacionS;
            tiemposprimerrespuestaS = ordenador.tiemposprimerrespuestaS;
            tiemposarriboS = ordenador.tiemposarriboS;
            //Obtiene datos originales de procesos
            for (int x = 0; x < cantidad; x++)
            {
                //-----------------------Obtiene datos orginales-----------------------------
                pend1CPU[x] = (Int32.Parse(DatosFlow.Rows[x].Cells[2].Value.ToString()));
                pendentrada[x] = (Int32.Parse(DatosFlow.Rows[x].Cells[3].Value.ToString()));
                pend2CPU[x] = (Int32.Parse(DatosFlow.Rows[x].Cells[4].Value.ToString()));
                pendsalida[x] = (Int32.Parse(DatosFlow.Rows[x].Cells[5].Value.ToString()));
                pend3CPU[x] = (Int32.Parse(DatosFlow.Rows[x].Cells[6].Value.ToString()));
                //--------------------------------------------------------------------------
                //Estadisticas para CPU
                tiemposarribo[x] = (Int32.Parse(DatosFlow.Rows[x].Cells[1].Value.ToString()));
                tiemposretorno[x] = tiemposfinalizacion[x] - tiemposarribo[x];
                sumaretorno += tiemposretorno[x];
                //MessageBox.Show("Las rafagas de CPU son "+ pend1CPU[x] +"/"+ pend2CPU[x] + "/" + pend3CPU[x]);
                tiemposirrupcion[x] = pend1CPU[x] + pend2CPU[x] + pend3CPU[x];
                tiemposespera[x] = tiemposretorno[x] - tiemposirrupcion[x];
                sumarespera += tiemposespera[x];
                tiemposrespuesta[x] = tiemposprimerrespuesta[x] - tiemposarribo[x];
                sumarespuesta += tiemposrespuesta[x];
                string idproceso = DatosFlow.Rows[x].Cells[0].Value.ToString();
                string[] estadistica = {idproceso, tiemposretorno[x].ToString(), tiemposirrupcion[x].ToString(), tiemposespera[x].ToString(), tiemposfinalizacion[x].ToString(), tiemposarribo[x].ToString(), tiemposretorno[x].ToString(), tiemposprimerrespuesta[x].ToString(), tiemposrespuesta[x].ToString() };
                estadisticasEjec.Rows.Add(estadistica);
                //Estadisticas para Entrada
                tiemposretornoE[x] = tiemposfinalizacionE[x] - tiemposarriboE[x];
                sumaretornoE += tiemposretornoE[x];
                tiemposirrupcionE[x] = pendentrada[x];
                tiemposesperaE[x] = tiemposretornoE[x] - tiemposirrupcionE[x];
                sumaresperaE += tiemposesperaE[x];
                tiemposrespuestaE[x] = tiemposprimerrespuestaE[x] - tiemposarriboE[x];
                sumarespuestaE += tiemposrespuestaE[x];
                string[] estadisticaE = { idproceso, tiemposretornoE[x].ToString(), tiemposirrupcionE[x].ToString(), tiemposesperaE[x].ToString(), tiemposfinalizacionE[x].ToString(), tiemposarriboE[x].ToString(), tiemposretornoE[x].ToString(), tiemposprimerrespuestaE[x].ToString(), tiemposrespuestaE[x].ToString() };
                estadisticasEjecE.Rows.Add(estadisticaE);
                //Estadisticas para Salida
                tiemposretornoS[x] = tiemposfinalizacionS[x] - tiemposarriboS[x];
                sumaretornoS += tiemposretornoS[x];
                tiemposirrupcionS[x] = pendsalida[x];
                tiemposesperaS[x] = tiemposretornoS[x] - tiemposirrupcionS[x];
                sumaresperaS += tiemposesperaS[x];
                tiemposrespuestaS[x] = tiemposprimerrespuestaS[x] - tiemposarriboS[x];
                sumarespuestaS += tiemposrespuestaS[x];
                string[] estadisticaS = { idproceso, tiemposretornoS[x].ToString(), tiemposirrupcionS[x].ToString(), tiemposesperaS[x].ToString(), tiemposfinalizacionS[x].ToString(), tiemposarriboS[x].ToString(), tiemposretornoS[x].ToString(), tiemposprimerrespuestaS[x].ToString(), tiemposrespuestaS[x].ToString() };
                estadisticasEjecS.Rows.Add(estadisticaS);
            }
            //Promedios CPU
            promespera = sumarespera / cantidad;
            promrespuesta = sumarespuesta / cantidad;
            promretorno = sumaretorno / cantidad;
            string[] estadistprom = { promespera.ToString(), promretorno.ToString(),promrespuesta.ToString()};
            Estadisticaspromedio.Rows.Add(estadistprom);
            //Promedios Entrada
            promesperaE = sumaresperaE / cantidad;
            promrespuestaE = sumarespuestaE / cantidad;
            promretornoE = sumaretornoE / cantidad;
            string[] estadistpromE = { promesperaE.ToString(), promretornoE.ToString(), promrespuestaE.ToString() };
            EstadisticaspromedioE.Rows.Add(estadistpromE);
            //Promedios Salida
            promesperaS = sumaresperaS / cantidad;
            promrespuestaS = sumarespuestaS / cantidad;
            promretornoS = sumaretornoS / cantidad;
            string[] estadistpromS = { promesperaS.ToString(), promretornoS.ToString(), promrespuestaS.ToString() };
            EstadisticaspromedioS.Rows.Add(estadistpromS);
        }
        private void imprimir()
        {
            //Imprime datos ejecucion 
            string colacpu="";
            int[] colalistos= ordenador.CPU.ToArray();
            int cantidadcpu = colalistos.Length;
            if (cantidadcpu == 0)
            {
                colacpu = "-";
            }
            else {
                for (int x = 0; x < cantidadcpu; x++)
                {
                    colacpu += DatosFlow.Rows[colalistos[x]].Cells[0].Value.ToString();
                    //+"("+(ordenador.rafagas[(ordenador.rafagas_actuales[x] - 1)][x])+")"
                    if (x!= (cantidadcpu - 1))
                    {
                        colacpu += ", ";
                    }
                }
            }
            string colaBE = "";
            int[] colBentrada = ordenador.BEntrada.ToArray();
            int cantidadBentrada = colBentrada.Length;
            if (cantidadBentrada == 0)
            {
                colaBE = "-";
            }
            else {
                for (int x = 0; x < cantidadBentrada; x++)
                {
                    colaBE += DatosFlow.Rows[colBentrada[x]].Cells[0].Value.ToString();
                    if (x != (cantidadBentrada - 1))
                    {
                        colaBE += ", ";
                    }
                }
            }
            string colaBS = "";
            int[] colBsalida = ordenador.BSalida.ToArray();
            int cantidadBsalida = colBsalida.Length;
            if (cantidadBsalida == 0)
            {
                colaBS = "-";
            }
            else {
                for (int x = 0; x < cantidadBsalida; x++)
                {
                    colaBS += DatosFlow.Rows[colBsalida[x]].Cells[0].Value.ToString();
                    if (x != (cantidadBsalida - 1))
                    {
                        colaBS += ", ";
                    }
                }
            }
            string colaE = "";
            int[] colentrada = ordenador.Entrada.ToArray();
            int cantidadentrada = colentrada.Length;
            if (cantidadentrada == 0)
            {
                colaE = "-";
            }
            else {
                for (int x = 0; x < cantidadentrada; x++)
                {
                    colaE += DatosFlow.Rows[colentrada[x]].Cells[0].Value.ToString();
                    if (x != (cantidadentrada - 1))
                    {
                        colaE += ", ";
                    }
                }
            }
            string colaS = "";
            int[] colsalida = ordenador.Salida.ToArray();
            int cantidadsalida = colsalida.Length;
            if (cantidadsalida == 0)
            {
                colaS = "-";
            }
            else {
                for (int x = 0; x < cantidadsalida; x++)
                {
                    colaS += DatosFlow.Rows[colsalida[x]].Cells[0].Value.ToString();
                    if (x != (cantidadsalida - 1))
                    {
                        colaS += ", ";
                    }
                }
            }
            string enejc = "";
            if (Int32.Parse(ordenador.uCPU.ToString()) == -1)
            {
                enejc = "-";
            } else
            {
                enejc = DatosFlow.Rows[Int32.Parse(ordenador.uCPU.ToString())].Cells[0].Value.ToString() ;
            }
            string enejcent = "";
            if (Int32.Parse(ordenador.UEntrada.ToString()) == -1)
            {
                enejcent = "-";
            }
            else
            {
                enejcent = DatosFlow.Rows[Int32.Parse(ordenador.UEntrada.ToString())].Cells[0].Value.ToString();
            }
            string enejcsal = "";
            if (Int32.Parse(ordenador.USalida.ToString()) == -1)
            {
                enejcsal = "-";
            }
            else
            {
                enejcsal = DatosFlow.Rows[Int32.Parse(ordenador.USalida.ToString())].Cells[0].Value.ToString();
            }
            string[] row = { reloj.ToString(), colacpu, enejc, colaBE+"/"+colaBS,colacpu,colaE,colaS, enejc, enejcent, enejcsal };
            FlujoEjec.Rows.Add(row);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Politica.Checked)
            {
                politica = FCFS;
            }
            if (Politica2.Checked)
            {
                politica = SJF;
            }
            if (Politica3.Checked)
            {
                politica = SRTF;
            }
            if (politicaESFCFS.Checked)
            {
                politicaES = FCFS;
            }
            if (politicaESSJF.Checked)
            {
                politicaES = SJF;
            }
            if (politicaESSRTF.Checked)
            {
                politicaES = SRTF;
            }
            FlujoEjec.Rows.Clear();
            reloj =0;
            int cantidad = (DatosFlow.RowCount) - 1;
            if (cantidad==0)
            {
                MessageBox.Show("No hay ningun proceso en la lista");
            }
            else {
                inicializar(cantidad);
                ordenador.politica = politica;
                ordenador.politicaES = politicaES;
                while (notermi())
                {
                    int[] respuesta = verificaraarribar(reloj);
                    //Si hay algun proceso para arribar
                    if (respuesta[0] != -1)
                    {
                        for (int x = 0; x < respuesta.Length; x++)
                        {
                            ordenador.agregarproceso(respuesta[x]);
                        }
                    }
                    ordenador.ejecutar(reloj);
                    imprimir();
                    reloj++;
                }

                imprimirestadisticas();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatosFlow.Rows.Clear();
        }

       private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    class Computador
    {
        public Computador(int cantproces,int[][] configuraciones)
        {
            // configuraciones[rafaga][num_proceso]
            rafagas = configuraciones;
            rafagas_actuales = new int[cantproces];
            tiemposfinalizacion = new int[cantproces];
            tiemposprimerrespuesta = new int[cantproces];
            tiemposarriboE = new int[cantproces];
            tiemposfinalizacionE = new int[cantproces];
            tiemposprimerrespuestaE = new int[cantproces];
            tiemposarriboS = new int[cantproces];
            tiemposfinalizacionS = new int[cantproces];
            tiemposprimerrespuestaS = new int[cantproces];
            hayarribo = false;
            hayarriboE = false;
            hayarriboS = false;
            for (int x=0; x< cantproces;x++)
            {
                //Recuerda la rafaga de CPU que tiene que ejecutar
                rafagas_actuales[x]=1;
            }
            cantidad_procesos = cantproces;
            uCPU = UEntrada = USalida = -1;
            TRestanteCPU = TRestanteEntrada = TRestanteSalida = 0;
            CPU = new Queue<int>();
            BEntrada = new Queue<int>();
            BSalida = new Queue<int>();
            Entrada = new Queue<int>();
            Salida = new Queue<int>();
        }
        //Contadores auxiliares
        public int[] rafagas_actuales;
        public int[][] rafagas;
        private int cantidad_procesos;
        public int TRestanteCPU;
        public int TRestanteEntrada;
        public int TRestanteSalida;
        bool hayarribo;
        bool hayarriboE;
        bool hayarriboS;
        public int politica, politicaES, instante;
        //Datos para estadisticas de procesos
        public int[] tiemposfinalizacion;
        public int[] tiemposprimerrespuesta;
        public int[] tiemposarriboE;
        public int[] tiemposfinalizacionE;
        public int[] tiemposprimerrespuestaE;
        public int[] tiemposarriboS;
        public int[] tiemposfinalizacionS;
        public int[] tiemposprimerrespuestaS;
        const int FCFS=1;
        const int SJF = 2;
        const int SRTF = 3;
        //Estados
        //Listo = Cola de CPU
        //Ejecucion=uCPU
        public Queue<int> BEntrada;
        public Queue<int> BSalida;
        //COLA de recursos
        public Queue<int> CPU;
        public Queue<int> Entrada;
        public Queue<int> Salida;
        //Uso recursos
        public int uCPU;
        public int UEntrada;
        public int USalida;
        public void agregarproceso(int num_proceso)
        {
            //Tendra en cuenta el valor del arreglo politica para definir el criterio de ordenacion de la cola de listos
           CPU.Enqueue(num_proceso);
            hayarribo = true;
            bool modificada = false;
            int temporal = -1;
            //Si se implementa politica SJF o SRTF se ordena la cola de listos
            if (politica == SJF || politica == SRTF)
            {
                int[] colaaccpu = CPU.ToArray();
                int cantidadcola = colaaccpu.Length;
                //Ordena la cola de listos teniendo en cuenta la primera rafaga de cada proceso
                for (int x = 0; x < (cantidadcola - 1); x++)
                {
                    for (int y = (x + 1); y < cantidadcola; y++)
                    {
                        if (rafagas[(rafagas_actuales[colaaccpu[x]] - 1)][colaaccpu[x]] > rafagas[(rafagas_actuales[colaaccpu[y]] - 1)][colaaccpu[y]])
                        {
                            temporal = colaaccpu[x];
                            colaaccpu[x] = colaaccpu[y];
                            colaaccpu[y] = temporal;
                            modificada = true;
                        }
                    }
                }
                if (modificada)
                {
                    CPU.Clear();
                    for (int x=0;x< cantidadcola; x++)
                    {
                        CPU.Enqueue(colaaccpu[x]);
                    }
                }
            }
            
        }
        public void agregarprocesoE(int num_proceso)
        {
            //Tendra en cuenta el valor del arreglo politica para definir el criterio de ordenacion de la cola de listos
            BEntrada.Enqueue(num_proceso);
            Entrada.Enqueue(num_proceso);
            hayarriboE = true;
            bool modificada = false;
            int temporal = -1;
            int temporal2 = -1;
            //Si se implementa politica SJF o SRTF se ordena la cola de listos
            if (politicaES == SJF || politicaES == SRTF)
            {
                int[] colaentrada = Entrada.ToArray();
                int[] colabentrada = BEntrada.ToArray();
                int cantidadcola = colaentrada.Length;
                //Ordena la cola de listos teniendo en cuenta la primera rafaga de cada proceso
                for (int x = 0; x < (cantidadcola - 1); x++)
                {
                    for (int y = (x + 1); y < cantidadcola; y++)
                    {
                        if (rafagas[1][colaentrada[x]] > rafagas[1][colaentrada[y]])
                        {
                            temporal = colaentrada[x];
                            temporal2 = colabentrada[x];
                            colaentrada[x] = colaentrada[y];
                            colabentrada[x] = colabentrada[y];
                            colaentrada[y] = temporal;
                            colabentrada[y] = temporal2;
                            modificada = true;
                        }
                    }
                }
                if (modificada)
                {
                    Entrada.Clear();
                    for (int x = 0; x < cantidadcola; x++)
                    {
                        Entrada.Enqueue(colaentrada[x]);
                    }
                }
            }

        }
        public void agregarprocesoS(int num_proceso)
        {
            //Tendra en cuenta el valor del arreglo politica para definir el criterio de ordenacion de la cola de listos
            BSalida.Enqueue(num_proceso);
            Salida.Enqueue(num_proceso);
            hayarriboS = true;
            bool modificada = false;
            int temporal = -1;
            int temporal2 = -1;
            //Si se implementa politica SJF o SRTF se ordena la cola de listos
            if (politicaES == SJF || politicaES == SRTF)
            {
                int[] colasalida = Salida.ToArray();
                int[] colabsalida = BSalida.ToArray();
                int cantidadcola = colasalida.Length;
                //Ordena la cola de listos teniendo en cuenta la primera rafaga de cada proceso
                for (int x = 0; x < (cantidadcola - 1); x++)
                {
                    for (int y = (x + 1); y < cantidadcola; y++)
                    {
                        if (rafagas[3][colasalida[x]] > rafagas[3][colasalida[y]])
                        {
                            temporal = colasalida[x];
                            temporal2 = colabsalida[x];
                            colasalida[x] = colasalida[y];
                            colabsalida[x] = colabsalida[y];
                            colasalida[y] = temporal;
                            colabsalida[y] = temporal2;
                            modificada = true;
                        }
                    }
                }
                if (modificada)
                {
                    Salida.Clear();
                    for (int x = 0; x < cantidadcola; x++)
                    {
                        Salida.Enqueue(colasalida[x]);
                    }
                }
            }

        }
        private void ejecutarcpu()
        {
            //Para el algoritmo SRTF existira una variable politica de tipo int que si es= a la constante SRTF en cada ciclo de ejecucion si arriba
            //en la cola de planificacion un proceso con tiempo de irrupcion menor que el actualmente ejecutando
            //En ese caso sacara de la ejecucion al proceso actual y lo ubicara en el lugar correspondiente en la cola
            int rafaga;
            int proceso;
            //Si no hay ningun proceso en ejecucion
            if (uCPU == -1)
            {
                //Si hay algun proceso en la cola de Listos lo pone en ejecucion
                //Orden FIFO
                if (CPU.Count != 0)
                {
                    proceso = CPU.Peek();
                    CPU.Dequeue();
                    // MessageBox.Show("Se inicia la ejecucion de " +proceso+" en instante "+instante);
                    uCPU = proceso;
                    //Descuenta el ciclo de reloj en curso
                    rafaga = rafagas_actuales[proceso];
                    //Si la rafaga es la primera almacena recuerda el instante de primer respuesta
                    if (rafaga == 1)
                    {
                        tiemposprimerrespuesta[proceso] = instante;
                    }
                    TRestanteCPU = rafagas[(rafagas_actuales[proceso] - 1)][proceso] - 1;
                    rafagas[(rafagas_actuales[proceso] - 1)][proceso] = 0;
                    //Recuerda que rafaga de CPU debera ejecutar en la proxima
                    rafagas_actuales[proceso] += 2;
                }
            }
            else {//Si ya hay algun proceso en ejecucion
                //Determina si ya ha terminado su ejecucion 
                if (TRestanteCPU == 0)
                {
                    rafaga = rafagas_actuales[uCPU];
                    //Si se termino de ejecutar la ultima rafaga del proceso recuerda el instante de finalizacion
                    if (rafaga == 7)
                    {
                        tiemposfinalizacion[uCPU] = instante;
                    }
                    //Lo agrega a la cola de entrada o salida dependiendo de la rafaga de cpu que deba ejecutar luego
                    if (rafagas_actuales[uCPU] == 3)
                    {
                        agregarprocesoE(uCPU);
                        tiemposarriboE[uCPU] = instante;
                        //Informa de un nuevo arribo a la cola de entrada
                    }
                    else if (rafagas_actuales[uCPU] == 5)
                    {
                        agregarprocesoS(uCPU);
                        tiemposarriboS[uCPU] = instante;
                        //Informa de un nuevo arribo a la cola de salida
                    }

                    //Si hay algun proceso en la cola de Listos lo pone en ejecucion
                    //Orden FIFO
                    if (CPU.Count != 0)
                    {
                        proceso = CPU.Peek();
                        CPU.Dequeue();
                        // MessageBox.Show("Se inicia la ejecucion de " +proceso+" en instante "+instante);
                        uCPU = proceso;
                        //Descuenta el ciclo de reloj en curso
                        rafaga = rafagas_actuales[proceso];
                        //Si la rafaga es la primera almacena recuerda el instante de primer respuesta
                        if (rafaga == 1)
                        {
                            tiemposprimerrespuesta[proceso] = instante;
                        }
                        TRestanteCPU = rafagas[(rafagas_actuales[proceso] - 1)][proceso] - 1;
                        rafagas[(rafagas_actuales[proceso] - 1)][proceso] = 0;
                        //Recuerda que rafaga de CPU debera ejecutar en la proxima
                        rafagas_actuales[proceso] += 2;
                    }
                    else
                    {//Si no hay ningun proceso en la cola restablece el valor del uso de CPU a 0
                        uCPU = -1;
                    }
                }
                else
                {//En caso de que se este usando politica SRTF
                   //Si no termino la ejecucion verifica si el primer proceso en la cola de listos arribo un proceso con tiempo de irrupcion menor
                 //que el actualmente en ejecucion
                    if (politica==SRTF && hayarribo)
                    {
                        hayarribo = false;
                       // MessageBox.Show("Hola");
                        if (CPU.Count!=0)
                        {
                            proceso = CPU.Peek();
                            rafaga = rafagas[(rafagas_actuales[proceso] - 1)][proceso];
                            if (rafaga < TRestanteCPU)
                            {
                                //Debera indicar que no termino la rafaga actual del proceso actualizando la cantidad de irrupciones pendientes
                                rafagas_actuales[uCPU] -= 2;
                                //MessageBox.Show("El proceso " + uCPU + " sale de ejecucion en el instante " + instante + " con la rafaga " + rafagas_actuales[uCPU]+"pendiente de terminar con "+ TRestanteCPU+" irrupciones");
                                rafagas[(rafagas_actuales[uCPU] - 1)][uCPU] = TRestanteCPU;
                                //Saca el nuevo proceso a ejecutar
                                CPU.Dequeue();
                                //Ordena la cola de listos 
                                agregarproceso(uCPU);
                                //Inicia la ejecucion del nuevo proceso
                                uCPU = proceso;
                                //Descuenta el ciclo de reloj en curso
                                rafaga = rafagas_actuales[proceso];
                                //Si la rafaga es la primera almacena recuerda el instante de primer respuesta
                                if (rafaga == 1)
                                {
                                    tiemposprimerrespuesta[proceso] = instante;
                                }
                                TRestanteCPU = rafagas[(rafagas_actuales[proceso] - 1)][proceso] - 1;
                                rafagas[(rafagas_actuales[proceso] - 1)][proceso] = 0;
                                //Recuerda que rafaga de CPU debera ejecutar en la proxima
                                rafagas_actuales[proceso] += 2;

                            }
                            else
                            {
                                TRestanteCPU--;
                            }
                        }
                        //MessageBox.Show("Chau.El proceso actualmente en ejecucion es "+(uCPU+1)+".La rafaga actual es "+ rafagas_actuales[uCPU]+" con " + rafagas[(rafagas_actuales[uCPU] - 1)][uCPU]+"irrupciones pendientes");
                        //MessageBox.Show("Existen "+CPU.Count+" en la cola de listos");
                        else
                        {
                            TRestanteCPU--;
                        }

                    }
                    else
                    {
                        //Sino simplemente continua con la ejecucion
                        TRestanteCPU--;
                        //MessageBox.Show("El proceso " + uCPU + " en el instante " + instante + "le quedan " + TRestanteCPU + " irrupciones");
                    }
                }
            }
        }

        private void ejecutarEntrada()
        {
            //Para el algoritmo SRTF existira una variable politica de tipo int que si es= a la constante SRTF en cada ciclo de ejecucion si arriba
            //en la cola de planificacion un proceso con tiempo de irrupcion menor que el actualmente ejecutando
            //En ese caso sacara de la ejecucion al proceso actual y lo ubicara en el lugar correspondiente en la cola
            int rafaga;
            int proceso;
            //Si no hay ningun proceso en ejecucion de entrada
            if (UEntrada == -1)
            {
                //Si hay algun proceso en la cola de Entrada lo pone en ejecucion
                //Orden FIFO
                if (Entrada.Count != 0)
                {
                    proceso = Entrada.Peek();
                    tiemposprimerrespuestaE[proceso] = instante;
                    //MessageBox.Show("Se inicia la ejecucion en entrada de " + proceso + " en instante " + instante);
                    Entrada.Dequeue();
                    UEntrada = proceso;
                    //Descuenta el ciclo de reloj en curso
                    TRestanteEntrada = rafagas[1][proceso] - 1;
                    rafagas[1][proceso] = 0;
                }
            }
            else {//Si ya hay algun proceso en ejecucion
                //Determina si ya ha terminado su ejecucion 
                if (TRestanteEntrada == 0)
                {
                    tiemposfinalizacionE[UEntrada] = instante;
                    //Desbloquea el proceso
                    BEntrada.Dequeue();
                    //Lo agrega a la cola de CPU
                    agregarproceso(UEntrada);

                    //Si hay algun proceso en la cola de Entrada lo pone en ejecucion
                    //Orden FIFO
                    if (Entrada.Count != 0)
                    {
                        proceso = Entrada.Peek();
                        tiemposprimerrespuestaE[proceso] = instante;
                        //MessageBox.Show("Se inicia la ejecucion en entrada de " + proceso + " en instante " + instante);
                        Entrada.Dequeue();
                        UEntrada = proceso;
                        //Descuenta el ciclo de reloj en curso
                        TRestanteEntrada = rafagas[1][proceso] - 1;
                        rafagas[1][proceso] = 0;
                    }
                    else
                    {//Si no hay ningun proceso en la cola restablece el valor del uso de Entrada a 0
                        UEntrada = -1;
                    }
                }
                else
                {//En caso de que se este usando politica SRTF
                 //Si no termino la ejecucion verifica si el primer proceso en la cola de listos arribo un proceso con tiempo de irrupcion menor
                 //que el actualmente en ejecucion
                    if (politicaES == SRTF && hayarriboE)
                    {
                        hayarriboE = false;
                        // MessageBox.Show("Hola");
                        if (Entrada.Count != 0)
                        {
                            proceso = Entrada.Peek();
                            rafaga = rafagas[1][proceso];
                            if (rafaga < TRestanteEntrada)
                            {
                                //Debera indicar que no termino la rafaga actual del proceso actualizando la cantidad de irrupciones pendientes
                                rafagas[1][UEntrada] = TRestanteEntrada;
                                //Saca el nuevo proceso a ejecutar
                                tiemposprimerrespuestaE[proceso] = instante;
                                Entrada.Dequeue();
                                BEntrada.Dequeue();
                                //Ordena la cola de listos 
                                agregarprocesoE(UEntrada);
                                //Inicia la ejecucion del nuevo proceso
                                UEntrada = proceso;
                                //Descuenta el ciclo de reloj en curso
                                TRestanteEntrada = rafagas[1][proceso] - 1;
                                rafagas[1][proceso] = 0;

                            }
                            else
                            {
                                TRestanteEntrada--;
                            }
                        }
                        else
                        {
                            TRestanteEntrada--;
                        }

                    }
                    else
                    {
                        //Sino simplemente continua con la ejecucion
                        TRestanteEntrada--;
                    }
                }
            }
        }

        private void ejecutarSalida()
        {
            //Para el algoritmo SRTF existira una variable politica de tipo int que si es= a la constante SRTF en cada ciclo de ejecucion si arriba
            //en la cola de planificacion un proceso con tiempo de irrupcion menor que el actualmente ejecutando
            //En ese caso sacara de la ejecucion al proceso actual y lo ubicara en el lugar correspondiente en la cola
            int rafaga;
            int proceso;
            //Si no hay ningun proceso en ejecucion de salida
            if (USalida == -1)
            {
                //Si hay algun proceso en la cola de Salida lo pone en ejecucion
                //Orden FIFO
                if (Salida.Count != 0)
                {
                    proceso = Salida.Peek();
                    tiemposprimerrespuestaS[proceso] = instante;
                    //MessageBox.Show("Se inicia la ejecucion en salida de " + proceso + " en instante " + instante);
                    Salida.Dequeue();
                    USalida = proceso;
                    //Descuenta el ciclo de reloj en curso
                    TRestanteSalida = rafagas[3][proceso] - 1;
                    rafagas[3][proceso] = 0;
                }
            }
            else {//Si ya hay algun proceso en ejecucion
                //Determina si ya ha terminado su ejecucion 
                if (TRestanteSalida == 0)
                {
                    tiemposfinalizacionS[USalida] = instante;
                    //Desbloquea el proceso
                    BSalida.Dequeue();
                    //Lo agrega a la cola de CPU
                    agregarproceso(USalida);

                    //Si hay algun proceso en la cola de Salida lo pone en ejecucion
                    //Orden FIFO
                    if (Salida.Count != 0)
                    {
                        proceso = Salida.Peek();
                        tiemposprimerrespuestaS[proceso] = instante;
                        //MessageBox.Show("Se inicia la ejecucion en salida de " + proceso + " en instante " + instante);
                        Salida.Dequeue();
                        USalida = proceso;
                        //Descuenta el ciclo de reloj en curso
                        TRestanteSalida = rafagas[3][proceso] - 1;
                        rafagas[3][proceso] = 0;
                    }
                    else
                    {//Si no hay ningun proceso en la cola restablece el valor del uso de Salida a 0
                        USalida = -1;
                    }
                }
                else
                {//En caso de que se este usando politica SRTF
                 //Si no termino la ejecucion verifica si el primer proceso en la cola de listos arribo un proceso con tiempo de irrupcion menor
                 //que el actualmente en ejecucion
                    if (politicaES == SRTF && hayarriboS)
                    {
                        hayarriboS = false;
                        // MessageBox.Show("Hola");
                        if (Salida.Count != 0)
                        {
                            proceso = Salida.Peek();
                            rafaga = rafagas[3][proceso];
                            if (rafaga < TRestanteSalida)
                            {
                                //Debera indicar que no termino la rafaga actual del proceso actualizando la cantidad de irrupciones pendientes
                                rafagas[3][USalida] = TRestanteSalida;
                                //Saca el nuevo proceso a ejecutar
                                tiemposprimerrespuestaS[proceso] = instante;
                                Salida.Dequeue();
                                BSalida.Dequeue();
                                //Ordena la cola de listos 
                                agregarprocesoS(USalida);
                                //Inicia la ejecucion del nuevo proceso
                                USalida = proceso;
                                //Descuenta el ciclo de reloj en curso
                                TRestanteSalida = rafagas[3][proceso] - 1;
                                rafagas[3][proceso] = 0;

                            }
                            else
                            {
                                TRestanteSalida--;
                            }
                        }
                        else
                        {
                            TRestanteSalida--;
                        }

                    }
                    else
                    {
                        //Sino simplemente continua con la ejecucion
                        TRestanteSalida--;
                    }
                }
            }
        }

        public void ejecutar(int instant)
        {// rafagas[rafaga][num_proceso]
            instante = instant;
            ejecutarcpu();
            ejecutarEntrada();
            ejecutarSalida();
            //Verifica si la CPU esta ociosa para atender procesos desbloqueados
             if (uCPU==-1)
            {
                ejecutarcpu();
            }
        }
        public bool noterminado()
        {
            if (CPU.Count == 0 && Entrada.Count == 0 && Salida.Count == 0 && uCPU == -1 && UEntrada == -1 && USalida == -1)
            {
                return false;
            }
            return true;
        }
    }
}
