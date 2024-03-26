namespace OOP.Animals {
    class Cat : Animal, IHealth {
        private string species;
        private int age;

        public Cat(double _weight = 0, double _height = 0, int _age = 0, string _species = "") : base(_weight, _height) {
            this.age = _age;
            this.species = _species;
        }
        public Cat(Cat cat) : base(cat) {
            this.age = cat.age;
            this.species = cat.species;
        }

        public string Species {
            get => this.species;
            set => this.species = value;
        }
        public int Age {
            get => this.age;
            set => this.age = value;
        }

        public override string ToString() {
            return base.ToString() + " | Species: " + Species + " | Age: " + Age;
        }

        public double GetRatio() {
            return Weight * Height * Age;
        }
    }
}
