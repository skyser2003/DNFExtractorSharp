﻿using System.Drawing;
using ExtractorSharp.Core.Command;
using ExtractorSharp.Core.Lib;
using ExtractorSharp.Core.Model;

namespace ExtractorSharp.Command.DrawCommand {
    internal class PencilDraw : ICommand {
        private Color Color;
        private Sprite Entity;
        private Bitmap Image;
        private Point Location;

        public string Name => "Pencil";

        public bool CanUndo => true;

        public bool IsChanged => false;

        public bool IsFlush => false;

        public void Do(params object[] args) {
            Entity = args[0] as Sprite;
            Location = (Point) args[1];
            Color = (Color) args[2];
            Image = Entity.Picture;
            var width = Image.Width;
            var height = Image.Height;
            var x = 0;
            var y = 0;
            var _x = 0;
            var _y = 0;
            if (Location.X < 0) {
                x = -Location.X + 1;
                Location.X = 0;
                _x = x;
            } else if (Location.X > width - 1) {
                x = Location.X - width + 1;
            }

            if (Location.Y < 0) {
                y = -Location.Y + 1;
                Location.Y = 0;
                _y = y;
            } else if (Location.Y > height - 1) {
                y = Location.Y - height + 1;
            }

            width += x;
            height += y;
            var image = new Bitmap(width, height);
            using (var g = Graphics.FromImage(image)) {
                g.DrawImage(Image, _x, _y, Image.Width, Image.Height);
            }

            image.SetPixel(Location.X, Location.Y, Color);
            Entity.Picture = image;
            Entity.Location = Entity.Location.Minus(new Point(_x, _y));
            Program.Connector.CanvasFlush();
        }

        public void Redo() {
            Do(Entity, Location, Color);
        }

        public void Undo() {
            Entity.Picture = Image;
        }

        public override string ToString() {
            return Language.Default["Pencil"];
        }
    }
}