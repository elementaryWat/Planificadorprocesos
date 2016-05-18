using System;
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

            int[] tiemposretornoE = new int[cantidad];
            int[] tiemposirrupcionE = new int[cantidad];
            int[] tiemposesperaE = new int[cantidad];
            int[] tiemposfinalizacionE = new int[cantidad];
            int[] tiemposprimerrespuestaE = new int[cantidad];
            int[] tiemposrespuestaE = new int[cantidad];
            //Obtiene estadiscticas de ordenador
            tiemposfinalizacionE = ordenador.tiemposfinalizacionE;
            tiemposprimerrespuestaE = ordenador.tiemposprimerrespuestaE;

            int[] tiemposretornoS = new int[cantidad];
            int[] tiemposirrupcionS = new int[cantidad];
            int[] tiemposesperaS = new int[cantidad];
            int[] tiemposfinalizacionS = new int[cantidad];
            int[] tiemposprimerrespuestaS = new int[cantidad];
            int[] tiemposrespuestaS = new int[cantidad];
            //Obtiene estadiscticas de ordenador
            tiemposfinalizacionS = ordenador.tiemposfinalizacionS;
            tiemposprimerrespuestaS = ordenador.tiemposprimerrespuestaS;
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
                tiemposretornoE[x] = tiemposfinalizacionE[x] - tiemposarribo[x];
                tiemposirrupcionE[x] = pendentrada[x];
                tiemposesperaE[x] = tiemposretornoE[x] - tiemposirrupcionE[x];
                tiemposrespuestaE[x] = tiemposprimerrespuestaE[x] - tiemposarribo[x];
                //Estadisticas para Salida
                tiemposretornoS[x] = tiemposfinalizacionS[x] - tiemposarribo[x];
                tiemposirrupcionS[x] = pendentrada[x];
                tiemposesperaS[x] = tiemposretornoS[x] - tiemposirrupcionS[x];
                tiemposrespuestaS[x] = tiemposprimerrespuestaS[x] - tiemposarribo[x];
            }
            promespera = sumarespera / cantidad;
            promrespuesta = sumarespuesta / cantidad;
            promretorno = sumaretorno / cantidad;
            string[] estadistprom = { promespera.ToString(), promretorno.ToString(),promrespuesta.ToString()};
            Estadisticaspromedio.Rows.Add(estadistprom);
        }
        private void imprimir()
        {
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
            FlujoEjec.Rows.Clear();
            reloj =0;
            int cantidad = (DatosFlow.RowCount) - 1;
            inicializar(cantidad);
            while (notermi())
            {
                int[] respuesta= verificaraarribar(reloj);
                //Si no hay ningun proceso para arribar
                if (respuesta[0] != -1)
                {
                    for (int x=0;x<respuesta.Length;x++)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatosFlow.Rows.Clear();
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
            tiemposfinalizacionE = new int[cantproces];
            tiemposprimerrespuestaE = new int[cantproces];
            tiemposfinalizacionS = new int[cantproces];
            tiemposprimerrespuestaS = new int[cantproces];
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
        int[] rafagas_actuales;
        int[][] rafagas;
        private int cantidad_procesos;
        private int TRestanteCPU;
        private int TRestanteEntrada;
        private int TRestanteSalida;
        //Datos para estadisticas de procesos
        public int[] tiemposfinalizacion;
        public int[] tiemposprimerrespuesta;
        public int[] tiemposfinalizacionE;
        public int[] tiemposprimerrespuestaE;
        public int[] tiemposfinalizacionS;
        public int[] tiemposprimerrespuestaS;
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
           CPU.Enqueue(num_proceso);
        }
        private void ejecutarcpu(int instante)
        {
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
                        Entrada.Enqueue(uCPU);
                        BEntrada.Enqueue(uCPU);
                    }
                    else if (rafagas_actuales[uCPU] == 5)
                    {
                        Salida.Enqueue(uCPU);
                        BSalida.Enqueue(uCPU);
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
                {
                    TRestanteCPU--;
                }
            }
        }
        public void ejecutar(int instante)
        {// rafagas[rafaga][num_proceso]
            int proceso;
            ejecutarcpu(instante);
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
                    CPU.Enqueue(UEntrada);

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
                {
                    TRestanteEntrada--;
                }
            }
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
                    CPU.Enqueue(USalida);

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
                {
                    TRestanteSalida--;
                }
            }
            //Verifica si la CPU esta ociosa para atender procesos desbloqueados
             if (uCPU==-1)
            {
                ejecutarcpu(instante);
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
