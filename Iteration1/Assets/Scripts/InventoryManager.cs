// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using UnityEngine;
using System.Collections;

public interface InventoryManager
{
	GameObject push(GameObject obj);
	GameObject push(GameObject obj, int index); //special for structs with positional: push may not do what it indicates!
												//to be fair, you shouldn't really care.
												//for structs where that isn't allowed, it just calls the original.
	GameObject pop();
	GameObject pop(int index);
	void clear();

	void updateHUD();

}


