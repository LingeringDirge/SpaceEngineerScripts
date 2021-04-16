/*
 * R e a d m e
 * -----------
 * Tag your Custom Data of your containers with lowercase strings, e.g. ore, component, tool, ingot
 * 
 * For sub types like ore you can name the container gold-ore, platinium-ore, etc.  If ore is found w/o the subtype it will be placed in
 * a container with teh ore type if it can find a container wiht that tag.
 */
List<IMyCargoContainer>W=new List<IMyCargoContainer>();List<IMyCargoContainer>X=new List<IMyCargoContainer>();List<
IMyCargoContainer>Y=new List<IMyCargoContainer>();List<IMyCargoContainer>Z=new List<IMyCargoContainer>();List<IMyCargoContainer>a=new
List<IMyCargoContainer>();List<IMyCargoContainer>b=new List<IMyCargoContainer>();List<IMyCargoContainer>c=new List<
IMyCargoContainer>();List<IMyCargoContainer>d=new List<IMyCargoContainer>();List<IMyCargoContainer>e=new List<IMyCargoContainer>();List<
IMyCargoContainer>f=new List<IMyCargoContainer>();List<IMyCargoContainer>g=new List<IMyCargoContainer>();List<IMyCargoContainer>h=new
List<IMyCargoContainer>();List<IMyCargoContainer>j=new List<IMyCargoContainer>();List<IMyCargoContainer>k=new List<
IMyCargoContainer>();List<IMyCargoContainer>l=new List<IMyCargoContainer>();List<IMyCargoContainer>m=new List<IMyCargoContainer>();List<
IMyCargoContainer>n=new List<IMyCargoContainer>();List<IMyCargoContainer>o=new List<IMyCargoContainer>();List<IMyCargoContainer>p=new
List<IMyCargoContainer>();List<IMyCargoContainer>q=new List<IMyCargoContainer>();List<IMyCargoContainer>r=new List<
IMyCargoContainer>();List<IMyCargoContainer>t=new List<IMyCargoContainer>();List<IMyCargoContainer>s=new List<IMyCargoContainer>();
Program(){Runtime.UpdateFrequency=UpdateFrequency.Update1;}void Main(string B,UpdateType C){D();H();}void D(){List<
IMyCargoContainer>E=new List<IMyCargoContainer>();GridTerminalSystem.GetBlocksOfType<IMyCargoContainer>(E);V();for(int F=0;F<E.Count;F++)
{var G=E[F];switch(G.CustomData.ToLower()){case"component":X.Add(G);break;case"ingot":k.Add(G);break;case"iron-ingot":l.
Add(G);break;case"cobalt-ingot":m.Add(G);break;case"nickel-ingot":n.Add(G);break;case"gold-ingot":o.Add(G);break;case
"magnesium-ingot":p.Add(G);break;case"platinum-ingot":q.Add(G);break;case"silicon-ingot":r.Add(G);break;case"silver-ingot":t.Add(G);break
;case"uranium-ingot":s.Add(G);break;case"tool":Y.Add(G);break;case"ore":Z.Add(G);break;case"iron-ore":a.Add(G);break;case
"cobalt-ore":b.Add(G);break;case"nickel-ore":c.Add(G);break;case"gold-ore":d.Add(G);break;case"magnesium-ore":e.Add(G);break;case
"platinum-ore":f.Add(G);break;case"silicon-ore":g.Add(G);break;case"silver-ore":h.Add(G);break;case"uranium-ore":j.Add(G);break;
default:W.Add(G);break;}}}void H(){for(int F=0;F<W.Count;F++){var I=W[F];var J=I.GetInventory(0);var K=J.ItemCount;for(int L=0;
L<K;L++){var M=J.GetItemAt(L);if(M.HasValue){var N=M.Value;var O=N.Type.GetItemInfo();var P=N.Type.SubtypeId.ToLower();if
(O.IsComponent){Q(N,J,X);}if(O.IsIngot){if(P.Contains("iron")){Q(N,J,l);}else if(P.Contains("gold")){Q(N,J,o);}else if(P.
Contains("nickel")){Q(N,J,n);}else if(P.Contains("cobalt")){Q(N,J,m);}else if(P.Contains("platinum")){Q(N,J,q);}else if(P.
Contains("magnesium")){Q(N,J,p);}else if(P.Contains("silicon")){Q(N,J,r);}else if(P.Contains("silver")){Q(N,J,t);}else if(P.
Contains("uranium")){Q(N,J,s);}else{Q(N,J,k);}}if(O.IsTool){Q(N,J,Y);}if(O.IsOre){if(P.Contains("iron")){Q(N,J,a);}else if(P.
Contains("gold")){Q(N,J,d);}else if(P.Contains("nickel")){Q(N,J,c);}else if(P.Contains("cobalt")){Q(N,J,b);}else if(P.Contains(
"platinum")){Q(N,J,f);}else if(P.Contains("magnesium")){Q(N,J,e);}else if(P.Contains("silicon")){Q(N,J,g);}else if(P.Contains(
"silver")){Q(N,J,h);}else if(P.Contains("uranium")){Q(N,J,j);}else{Q(N,J,Z);}}}}}}void Q(MyInventoryItem R,IMyInventory S,List<
IMyCargoContainer>T){for(int U=0;U<T.Count;U++){var A=T[U].GetInventory(0);S.TransferItemTo(A,R);}}void V(){W.Clear();X.Clear();k.Clear()
;Y.Clear();Z.Clear();d.Clear();}
