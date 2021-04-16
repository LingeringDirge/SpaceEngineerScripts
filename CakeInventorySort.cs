/*
 * R e a d m e
 * -----------
 * Tag your Custom Data of your containers with lowercase strings, e.g. ore, component, tool, ingot
 * 
 * For sub types like ore you can name the container gold-ore, platinium-ore, etc.  If ore is found w/o the subtype it will be placed in
 * a container with teh ore type if it can find a container wiht that tag.
 */
List<IMyCargoContainer>Z=new List<IMyCargoContainer>();List<IMyCargoContainer>Y=new List<IMyCargoContainer>();List<
IMyCargoContainer>X=new List<IMyCargoContainer>();List<IMyCargoContainer>W=new List<IMyCargoContainer>();List<IMyCargoContainer>V=new
List<IMyCargoContainer>();Program(){Runtime.UpdateFrequency=UpdateFrequency.Update1;}void Main(string U,UpdateType T){S();a(
);}void S(){List<IMyCargoContainer>R=new List<IMyCargoContainer>();GridTerminalSystem.GetBlocksOfType<IMyCargoContainer>(
R);A();for(int P=0;P<R.Count;P++){var Q=R[P];switch(Q.CustomData.ToLower()){case"component":Y.Add(Q);break;case"ingot":V.
Add(Q);break;case"tool":X.Add(Q);break;case"ore":W.Add(Q);break;default:Z.Add(Q);break;}}}void a(){for(int P=0;P<Z.Count;P
++){var N=Z[P];var M=N.GetInventory(0);var L=M.ItemCount;for(int K=0;K<L;K++){var J=M.GetItemAt(K);if(J.HasValue){var I=J.
Value;var H=I.Type.GetItemInfo();var G=I.Type.SubtypeId.ToLower();if(H.IsComponent){F(I,M,Y);}if(H.IsIngot){F(I,M,V);}if(H.
IsTool){F(I,M,X);}if(H.IsOre){F(I,M,W);}}}}}void F(MyInventoryItem E,IMyInventory D,List<IMyCargoContainer>C){for(int B=0;B<C.
Count;B++){var O=C[B].GetInventory(0);D.TransferItemTo(O,E);}}void A(){Z.Clear();Y.Clear();X.Clear();}
