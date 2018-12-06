namespace TrainingProject5Tpl
{
    internal class ParametersToPass
    {
        private int v1;
        private int v2;

        public ParametersToPass(int v1, int v2)
        {
            this.V1 = v1;
            this.V2 = v2;
        }

        public int V1 { get => v1; set => v1 = value; }
        public int V2 { get => v2; set => v2 = value; }
    }
}