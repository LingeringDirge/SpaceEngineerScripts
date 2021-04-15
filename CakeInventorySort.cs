/*
 * R e a d m e
 * -----------
 * Tag your Custom Data of your containers with lowercase strings, e.g. ore, component, tool, ingot
 * 
 * For sub types like ore you can name the container gold-ore, platinium-ore, etc.  If ore is found w/o the subtype it will be placed in
 * a container with teh ore type if it can find a container wiht that tag.
 */
List<IMyCargoContainer>U=new List<IMyCargoContainer>();List<IMyCargoContainer>V=new List<IMyCargoContainer>();List<
IMyCargoContainer>W=new List<IMyCargoContainer>();List<IMyCargoContainer>X=new List<IMyCargoContainer>();List<IMyCargoContainer>Y=new
List<IMyCargoContainer>();List<IMyCargoContainer>Z=new List<IMyCargoContainer>();List<IMyCargoContainer>a=new List<
IMyCargoContainer>();List<IMyCargoContainer>b=new List<IMyCargoContainer>();List<IMyCargoContainer>c=new List<IMyCargoContainer>();List<
IMyCargoContainer>d=new List<IMyCargoContainer>();List<IMyCargoContainer>e=new List<IMyCargoContainer>();List<IMyCargoContainer>f=new
List<IMyCargoContainer>();List<IMyCargoContainer>g=new List<IMyCargoContainer>();List<IMyCargoContainer>h=new List<
IMyCargoContainer>();Program(){Runtime.UpdateFrequency=UpdateFrequency.Update1;}void Save(){}void Main(string k,UpdateType j){T();D();}
void T(){List<IMyCargoContainer>R=new List<IMyCargoContainer>();GridTerminalSystem.GetBlocksOfType<IMyCargoContainer>(R);S()
;for(int B=0;B<R.Count;B++){var C=R[B];switch(C.CustomData.ToLower()){case"component":V.Add(C);break;case"ingot":W.Add(C)
;break;case"tool":X.Add(C);break;case"ore":Y.Add(C);break;case"iron-ore":Z.Add(C);break;case"cobalt-ore":a.Add(C);break;
case"nickel-ore":b.Add(C);break;case"gold-ore":c.Add(C);break;case"magnesium-ore":d.Add(C);break;case"platinum-ore":e.Add(C)
;break;case"silicon-ore":f.Add(C);break;case"silver-ore":g.Add(C);break;case"uranium-ore":h.Add(C);break;default:U.Add(C)
;break;}}}void D(){for(int B=0;B<U.Count;B++){var E=U[B];var F=E.GetInventory(0);var G=F.ItemCount;for(int H=0;H<G;H++){
var I=F.GetItemAt(H);if(I.HasValue){var J=I.Value;var K=J.Type.GetItemInfo();if(K.IsComponent){M(J,F,V);}if(K.IsIngot){M(J,
F,W);}if(K.IsTool){M(J,F,X);}if(K.IsOre){var L=J.Type.SubtypeId.ToLower();Echo(L);if(L.Contains("iron")){M(J,F,Z);}else
if(L.Contains("gold")){M(J,F,c);}else if(L.Contains("nickel")){M(J,F,b);}else if(L.Contains("cobalt")){M(J,F,a);}else if(L
.Contains("platinum")){M(J,F,e);}else if(L.Contains("magnesium")){M(J,F,d);}else if(L.Contains("silicon")){M(J,F,f);}else
if(L.Contains("silver")){M(J,F,g);}else if(L.Contains("uranium")){M(J,F,h);}else{M(J,F,Y);}}}}}}void M(MyInventoryItem N,
IMyInventory O,List<IMyCargoContainer>P){for(int Q=0;Q<P.Count;Q++){var A=P[Q].GetInventory(0);O.TransferItemTo(A,N);}}void S(){U.
Clear();V.Clear();W.Clear();X.Clear();Y.Clear();c.Clear();}
