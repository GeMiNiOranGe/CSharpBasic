namespace OOP.Animals {
    class Animal {
        private double weight, height;

        public Animal(double _weight = 0, double _height = 0) {
            weight = _weight;
            this.height = _height;
        }
        public Animal(Animal animal) {
            this.weight = animal.weight;
            this.height = animal.height;
        }

        public double Weight {
            get => this.weight;
            set => this.weight = value;
        }
        public double Height {
            get => this.height;
            set => this.height = value;
        }

        public override string ToString() {
            return "Weight: " + Weight + " | Height: " + Height;
        }
    }
}
