public class ElectricCalculate{
    float[] chula = new float[] {10.2f, 7.3f ,8.4f, 5.6f, 9.3f, 4.6f, 1.2f, 7.5f, 8.2f, 4.3f, 6.0f, 7.0f};
    float[] mu = new float[] {9.2f, 5.2f, 8.9f, 7.1f, 9.3f, 2.2f, 1.7f, 5.2f, 9.1f, 8.4f, 2.1f, 2.3f};
    float[] kmitl = new float[] {17.2f, 19f, 23f, 25.1f, 31f, 32.1f, 17.0f, 14f, 11.3f, 18.1f, 19.2f, 22f};
    float[] kku = new float[] {2.1f, 2.0f, 1.1f, 1.5f, 3.2f, 4.1f, 2.2f, 2.2f, 1.3f, 1.4f, 5.0f, 4.1f };
    float[] kmutt = new float[] {17.2f, 20f, 23f, 25.1f, 31f, 4.1f, 17.0f, 14f, 11.3f, 5.0f, 19.2f, 22f };
    static List<float> ftList = new List<float>();
    static float minFT;

    public ElectricCalculate() {}

    public void Calculate(){
        float chulasum = chula.Sum();
        ftList.Add(chulasum);
        float musum = mu.Sum();
        ftList.Add(musum);
        float kmitlsum = kmitl.Sum();
        ftList.Add(kmitlsum);
        float kkusum = kku.Sum();
        ftList.Add(kkusum);
        float kmuttsum = kmutt.Sum();
        ftList.Add(kmuttsum);
    }
    
    public static float MinFT{
        get {return minFT;}
        set {minFT = value;}
    }

    public static List<float> FtList{
        get{return ftList;}
        set{ftList = value;}
    }
}