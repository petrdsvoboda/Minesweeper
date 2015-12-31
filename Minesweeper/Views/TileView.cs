﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drawing = System.Drawing;
using Forms = System.Windows.Forms;

namespace Minesweeper {
    class TileView : System.Windows.Forms.Button {

        private Coordinates _position;

        public Coordinates Position {
            get { return _position; }
            set {
                _position = value;
                this.Location = new Drawing.Point(_position.X * 25, _position.Y * 25);
            }
        }

        private bool _revealed;

        public bool Revealed
        {
            get { return _revealed; }
            set { _revealed = value; }
        }

        public TileView(Coordinates position, string neighbourMineCount, List<TileObject> objects, Forms.Form parent) {
            this.Width = 25;
            this.Height = 25;
            this.Position = position;
            this.Text = neighbourMineCount;
            if (neighbourMineCount == "0")
                this.Text = "";
            if (objects.Contains(TileObject.Mine))
                this.Text = "*";
            this.Parent = parent;
        }
    }
}