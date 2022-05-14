# Graph algorithms

## Surface Check
It's algorithm to find maximum rectangle surface possibly creating from pillars created based on array values. 
  
Here should by 18:  
![graph](adres "Graph of algorithms times")  
  
Here 10: 
![graph](adres "Graph of algorithms times") 

Probably I can use recursion, but right now is:  
1. Outside loop from minimum value of array to maximum value  
2. Inside loop again for every element in array  
3. If inside element >= outside element  
	`currentSurface += outsideElement`  
	`continue;`  
4. Else currentSurface value is added to surfaces collection, and currentSurface is again 0
5. After every inside loop add currentSurface to collection and reset this value.  
6. After outside loop finished work return surfaces.Max()