using Arkanoid.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class FormArkanoid : Form
    {

        //Variables para comprobar si se pulsa tecla mover derecha-izquierda
        bool btnLeftPressed = false;
        bool btnRightPressed = false;

        //Guardamos el movimiento con el que inicia la pelota
        private int movimientoActual = 1;

        //Contador de vidas del jugador
        int vidas = 3;

        //Contador de vidas del boss
        int vidasBoss = 5;

        //Guardamos el modo de juego actual
        int modoActualDeJuego;

        //NO FUNCIONA TODAVIA
        List<PictureBox> filaBlocks;

        //Enum con los modos de juego
        enum modosDeJuego
        {
            inicio,
            inGame,
            gameOver
        }

        public FormArkanoid()
        {
            InitializeComponent();

            modoActualDeJuego = (int) modosDeJuego.inicio;

            //Informa al usuario de que tiene que presionar space para empezar
            pictureBoxInitialImage.Visible = true;
            pictureBoxInitialImage.BringToFront();
            labelPress.Visible = true;
            labelPress.BringToFront();
            pictureSpace.Visible = true;
            pictureSpace.BringToFront();

            //Establecemos intervalo de refresco para el timer
            timer.Interval = 5;

            crearBlocks(3, 8);
        }

        //Timer para mover la pelota
        private void timer_Tick(object sender, EventArgs e)
        {
            //Mostramos graficamente las vidas del usuario
            mostrarVidas();

            //Vamos comprobando posibles rebotes
            rebotes();
            rebotesBlocks();

            //Comprobar si se golpea al boss
            hitBoss();

            //Inicio
            if (modoActualDeJuego == (int) modosDeJuego.inicio)
            {
                //Si esta en el inicio que no haga nada
            }
            //Jugando
            else if (modoActualDeJuego == (int) modosDeJuego.inGame)
            {
                //Move the bar
                moveBar();

                //Actualizamos movimientos
                switch (movimientoActual)
                {
                    case 1:
                        movimiento1();
                        break;
                    case 2:
                        movimiento2();
                        break;
                    case 3:
                        movimiento3();
                        break;
                    case 4:
                        movimiento4();
                        break;
                }
            }
            //Game over
            else if (modoActualDeJuego == (int)modosDeJuego.gameOver)
            {
                //Si esta en el game over que no haga nada
            }

        }

        //Movimiento Arriba - Derecha
        private void movimiento1()
        {
            pictureBoxPelota.Top = pictureBoxPelota.Top - 15;
            pictureBoxPelota.Left = pictureBoxPelota.Left + 15;
        }

        //Movimiento Abajo - Derecha
        private void movimiento2()
        {
            pictureBoxPelota.Top = pictureBoxPelota.Top + 15;
            pictureBoxPelota.Left = pictureBoxPelota.Left + 15;
        }

        //Movimiento Abajo - Izquierda
        private void movimiento3()
        {
            pictureBoxPelota.Top = pictureBoxPelota.Top + 15;
            pictureBoxPelota.Left = pictureBoxPelota.Left - 15;
        }

        //Movimiento Arriba - Izquierda
        private void movimiento4()
        {
            pictureBoxPelota.Top = pictureBoxPelota.Top - 15;
            pictureBoxPelota.Left = pictureBoxPelota.Left - 15;
        }

        //Rebotes
        private void rebotes()
        {
            //Movimiento 1 - Rebota TOP
            if (pictureBoxPelota.Top <= 0 && movimientoActual == 1)
            {
                movimientoActual = 2;
            }
            //Movimiento 1 - Rebota Right
            else if (pictureBoxPelota.Left + pictureBoxPelota.Width >= FormArkanoid.ActiveForm.ClientSize.Width && movimientoActual == 1)
            {
                movimientoActual = 4;
            }
            //Movimiento 2 - Rebota Right
            else if (pictureBoxPelota.Left + pictureBoxPelota.Width >= FormArkanoid.ActiveForm.ClientSize.Width && movimientoActual == 2)
            {
                movimientoActual = 3;
            }
            //Movimiento 2 - Rebota Bottom
            else if (pictureBoxPelota.Top + pictureBoxPelota.Height >= FormArkanoid.ActiveForm.ClientSize.Height && movimientoActual == 2)
            {
                movimientoActual = 1;

                //Le restamos una vida al usuario por tocar la parte de abajo
                restarVida();
            }
            //Movimiento 2 - Rebote barra
            else if (pictureBoxPelota.Top + pictureBoxPelota.Height >= pictureBoxBarra.Top
                && pictureBoxPelota.Left + pictureBoxPelota.Width >= pictureBoxBarra.Left
                && pictureBoxPelota.Left <= pictureBoxBarra.Left + pictureBoxBarra.Width
                && movimientoActual == 2)
            {
                movimientoActual = 1;
            }
            //Movimiento 3 - Rebota Bottom
            else if (pictureBoxPelota.Top + pictureBoxPelota.Height >= FormArkanoid.ActiveForm.ClientSize.Height && movimientoActual == 3)
            {
                movimientoActual = 4;

                //Le restamos una vida al usuario por tocar la parte de abajo
                restarVida();
            }
            //Movimiento 3 - Rebota Left
            else if (pictureBoxPelota.Left <= 0 && movimientoActual == 3)
            {
                movimientoActual = 2;
            }
            //Movimiento 3 - Rebote barra
            else if (pictureBoxPelota.Top + pictureBoxPelota.Height >= pictureBoxBarra.Top
                && pictureBoxPelota.Left + pictureBoxPelota.Width >= pictureBoxBarra.Left
                && pictureBoxPelota.Left <= pictureBoxBarra.Left + pictureBoxBarra.Width
                && movimientoActual == 3)
            {
                movimientoActual = 4;
            }
            //Movimiento 4 - Rebota Left
            else if (pictureBoxPelota.Left <= 0 && movimientoActual == 4)
            {
                movimientoActual = 1;
            }
            //Movimiento 4 - Rebota Top
            else if (pictureBoxPelota.Top <= 0 && movimientoActual == 4)
            {
                movimientoActual = 3;
            }
        }

        //Codigo de rebotes contra los bloques
        private void rebotesBlocks()
        {
            foreach (PictureBox ptb in filaBlocks)
            {
                //Movimiento 1 - Rebota block
                if (pictureBoxPelota.Top <= ptb.Top + ptb.Height &&
                    pictureBoxPelota.Top + pictureBoxPelota.Height >= ptb.Top &&
                    pictureBoxPelota.Left + pictureBoxPelota.Width >+ ptb.Left &&
                    pictureBoxPelota.Left <+ ptb.Left + ptb.Width &&
                    movimientoActual == 1)
                {
                    movimientoActual = 2;
                    ptb.Dispose();
                    filaBlocks.Remove(ptb);
                    break;
                }
                //Movimiento 4 - Rebota block
                else if (pictureBoxPelota.Top <= ptb.Top + ptb.Height &&
                    pictureBoxPelota.Top + pictureBoxPelota.Height >= ptb.Top &&
                    pictureBoxPelota.Left + pictureBoxPelota.Width > +ptb.Left &&
                    pictureBoxPelota.Left < +ptb.Left + ptb.Width &&
                    movimientoActual == 4)
                {
                    movimientoActual = 3;
                    ptb.Dispose();
                    filaBlocks.Remove(ptb);
                    break;
                }
                //Movimiento 2 - Rebota block
                else if (pictureBoxPelota.Top <= ptb.Top + ptb.Height &&
                    pictureBoxPelota.Top + pictureBoxPelota.Height >= ptb.Top &&
                    pictureBoxPelota.Left + pictureBoxPelota.Width > +ptb.Left &&
                    pictureBoxPelota.Left < +ptb.Left + ptb.Width &&
                    movimientoActual == 2)
                {
                    movimientoActual = 1;
                    ptb.Dispose();
                    filaBlocks.Remove(ptb);
                    break;
                }
                //Movimiento 3 - Rebota block
                else if (pictureBoxPelota.Top <= ptb.Top + ptb.Height &&
                    pictureBoxPelota.Top + pictureBoxPelota.Height >= ptb.Top &&
                    pictureBoxPelota.Left + pictureBoxPelota.Width > +ptb.Left &&
                    pictureBoxPelota.Left < +ptb.Left + ptb.Width &&
                    movimientoActual == 3)
                {
                    movimientoActual = 4;
                    ptb.Dispose();
                    filaBlocks.Remove(ptb);
                    break;
                }
            }
        }

        //Hit the boss
        private void hitBoss()
        {
            //Movimiento 1 - Rebote boss
            if (pictureBoxPelota.Top <= pictureBoxFinalBoss.Top + pictureBoxFinalBoss.Height &&
                pictureBoxPelota.Top + pictureBoxPelota.Height >= pictureBoxFinalBoss.Top &&
                pictureBoxPelota.Left + pictureBoxPelota.Width > +pictureBoxFinalBoss.Left &&
                pictureBoxPelota.Left < pictureBoxFinalBoss.Left + pictureBoxFinalBoss.Width &&
                movimientoActual == 1)
            {
                movimientoActual = 2;
                restarVidaBoss();
            }
            //Movimiento 4 - Rebote boss
            else if (pictureBoxPelota.Top <= pictureBoxFinalBoss.Top + pictureBoxFinalBoss.Height &&
                pictureBoxPelota.Top + pictureBoxPelota.Height >= pictureBoxFinalBoss.Top &&
                pictureBoxPelota.Left + pictureBoxPelota.Width > +pictureBoxFinalBoss.Left &&
                pictureBoxPelota.Left < pictureBoxFinalBoss.Left + pictureBoxFinalBoss.Width &&
                movimientoActual == 4)
            {
                movimientoActual = 3;
                restarVidaBoss();
            }
        }

        //Resta vida al jugador
        private void restarVida()
        {
            if (vidas != 0)
            {
                vidas--;
            }
        }

        //Resta vida al boss
        private void restarVidaBoss()
        {
            if(vidas != 0)
            {
                vidasBoss--;
            }
        }

        private void mostrarVidas()
        {
            switch (vidas)
            {
                case 3:
                    vidas1.Visible = true;
                    vidas2.Visible = true;
                    vidas3.Visible = true;
                    break;
                case 2:
                    vidas1.Visible = true;
                    vidas2.Visible = true;
                    vidas3.Visible = false;
                    break;
                case 1:
                    vidas1.Visible = true;
                    vidas2.Visible = false;
                    vidas3.Visible = false;
                    break;
                case 0:
                    vidas1.Visible = false;
                    vidas2.Visible = false;
                    vidas3.Visible = false;
                    gameOver();
                    break;
            }

            switch (vidasBoss)
            {
                case 5:
                    vidaBoss1.Visible = true;
                    vidaBoss2.Visible = true;
                    vidaBoss3.Visible = true;
                    vidaBoss4.Visible = true;
                    vidaBoss5.Visible = true;
                    break;
                case 4:
                    vidaBoss1.Visible = true;
                    vidaBoss2.Visible = true;
                    vidaBoss3.Visible = true;
                    vidaBoss4.Visible = true;
                    vidaBoss5.Visible = false;

                    //Condicion para que solo cambie la imagen una vez
                    if (pictureBoxFinalBoss.Image.Equals(pictureBoxBossSano.Image)) {
                        //Cambia la imagen de Trump
                        pictureBoxFinalBoss.Image = pictureBoxBossHerido1.Image;
                    }
                    
                    break;
                case 3:
                    vidaBoss1.Visible = true;
                    vidaBoss2.Visible = true;
                    vidaBoss3.Visible = true;
                    vidaBoss4.Visible = false;
                    vidaBoss5.Visible = false;
                    break;
                case 2:
                    vidaBoss1.Visible = true;
                    vidaBoss2.Visible = true;
                    vidaBoss3.Visible = false;
                    vidaBoss4.Visible = false;
                    vidaBoss5.Visible = false;
                    break;
                case 1:
                    vidaBoss1.Visible = true;
                    vidaBoss2.Visible = false;
                    vidaBoss3.Visible = false;
                    vidaBoss4.Visible = false;
                    vidaBoss5.Visible = false;


                    //Condicion para que solo cambie la imagen una vez
                    if (pictureBoxFinalBoss.Image.Equals(pictureBoxBossHerido1.Image))
                    {
                        //Cambia la imagen de Trump
                        pictureBoxFinalBoss.Image = pictureBoxBossHerido2.Image;
                    }
                    
                    break;
                case 0:
                    vidaBoss1.Visible = false;
                    vidaBoss2.Visible = false;
                    vidaBoss3.Visible = false;
                    vidaBoss4.Visible = false;
                    vidaBoss5.Visible = false;
                    victory();
                    break;
            }
        }

        //Evento para mover la barra
        private void moveBar()
        {
            if (btnLeftPressed)
            {
                if (pictureBoxBarra.Left <= 0)
                    {
                        //Si la barra ya ha llegado al limite por la izquierda entonces no la movemos
                }else{
                    //Movemos la barra a la izquierda
                    pictureBoxBarra.Left = pictureBoxBarra.Left - 30;
                }
            }else if (btnRightPressed)
            {
                if (pictureBoxBarra.Left + pictureBoxBarra.Width >= FormArkanoid.ActiveForm.ClientSize.Width)
                {
                    //Si la barra ya ha llegado al limite por la izquierda entonces no la movemos
                }
                else
                {
                    //Movemos la barra a la derecha
                    pictureBoxBarra.Left = pictureBoxBarra.Left + 30;
                } 
            }
        }

        //Pulsar tecla mover barra
        private void FormArkanoid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                btnLeftPressed = true;
                btnRightPressed = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                btnRightPressed = true;
                btnLeftPressed = false;
            }
        }

        // Soltar tecla mover barra
        private void FormArkanoid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                btnLeftPressed = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                btnRightPressed = false;
            }
        }

        //Empezar partida pulsando tecla Space
        private void empezarJuego(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space && modoActualDeJuego == 0)
            {
                //Ocultamos imagenes que informan al usuario de que tiene que presionar space para empezar
                pictureBoxInitialImage.Visible = false;
                labelPress.Visible = false;
                pictureSpace.Visible = false;

                modoActualDeJuego = (int)modosDeJuego.inGame;
            }
            else if (e.KeyChar == (char)Keys.Space && modoActualDeJuego == 2)
            {
                resetGame();
            }
        }

        //Cuando el usuario toca el suelo...
        private void gameOver()
        {
            //Cambiamos el modo de juego
            modoActualDeJuego = (int)modosDeJuego.gameOver;
            //Mostramos imagen informativa de que el usuario ha muerto
            pictureBoxGameOver.Visible = true;
        }

        //Usuario gana la partida
        private void victory()
        {
            //Cambiamos el modo de juego
            modoActualDeJuego = (int)modosDeJuego.gameOver;
            //Mostramos imagen informativa de que el usuario ha muerto
            pictureBoxVictory.Visible = true;
        }

        //Method crear bloques
        private void crearBlocks(int numRows, int numColumns)
        {
            int posX = 50;
            int posY = 100;

            filaBlocks = new List<PictureBox>();
            Random a = new Random();
            PictureBox ptbBlock;

            //X rows
            for (int i = 0; i < numRows; i++)
            {
                //X columns
                for (int j = 0; j < numColumns; j++)
                {
                    ptbBlock = new PictureBox();
                    ptbBlock.Image = pictureBoxBlock.Image;
                    ptbBlock.Location = new System.Drawing.Point(posX, posY);
                    ptbBlock.Name = "ptbBlock" + i + "_" + j;
                    ptbBlock.Size = new System.Drawing.Size(50, 50);
                    ptbBlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    ptbBlock.TabIndex = 6;
                    ptbBlock.TabStop = false;
                    this.Controls.Add(ptbBlock);
                    filaBlocks.Add(ptbBlock);
                    posX += 100;
                }
                posX = 50;
                posY += 75;
            }
            Application.DoEvents();
        }

        private void resetGame()
        {
            //Recolodamos la barra y la pelota
            pictureBoxBarra.Location = new System.Drawing.Point(342, 486);
            pictureBoxPelota.Location = new System.Drawing.Point(416, 440);

            //Reseteamos modoActualDeJuego
            modoActualDeJuego = (int)modosDeJuego.inicio;

            //Informa al usuario de que tiene que presionar space para empezar
            pictureBoxInitialImage.Visible = true;
            labelPress.Visible = true;
            pictureSpace.Visible = true;

            //Limpiamos los bloques del control
            foreach (PictureBox pbx in filaBlocks)
            {
                this.Controls.Remove(pbx);
            }

            //Limpiamos los bloques
            filaBlocks.Clear();

            //Creamos bloques
            crearBlocks(3, 8);

            //Reset el movimiento con el que inicia la pelota
            movimientoActual = 1;

            //Reset contador de vidas del jugador
            vidas = 3;

            //Reset contador de vidas del boss
            vidasBoss = 5;

            //Reseteamos la imagen del boss
            pictureBoxFinalBoss.Image = pictureBoxBossSano.Image;

            //Ocultamos imagen final
            pictureBoxGameOver.Visible = false;
            pictureBoxVictory.Visible = false;
    }
    }
}