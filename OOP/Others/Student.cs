namespace OOP.Others {
    class Student {
        private string code, name;
        private static double mathScore, literatureScore, physicsScore;

        public Student(string _code = "", string _name = "", double _mathScore = 0, double _literatureScore = 0, double _physicsScore = 0) {
            code = _code;
            Ten = _name;
            mathScore = _mathScore;
            literatureScore = _literatureScore;
            physicsScore = _physicsScore;
        }

        public string MaSV {
            get => code;
            set => code = value;
        }
        public string Ten {
            get => name;
            set => name = value;
        }
        public static double MathScore {
            get => mathScore;
            set {
                if (0 <= value && value <= 10) {
                    mathScore = value;
                }
            }
        }
        public static double LiteratureScore {
            get => literatureScore;
            set {
                if (0 <= value && value <= 10) {
                    mathScore = value;
                }
            }
        }
        public static double PhysicsScore {
            get => physicsScore;
            set {
                if (0 <= value && value <= 10) {
                    mathScore = value;
                }
            }
        }

        public static double CalculateAverageScore() {
            return (MathScore + LiteratureScore + PhysicsScore) / 3;
        }
    }
}
