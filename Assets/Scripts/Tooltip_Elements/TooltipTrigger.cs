using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public string sinkHeader;
    public string sinkContent;
    public string dryerHeader;
    public string dryerContent;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(PlayerPrefs.GetInt("Sink Selected")!= 1)
        {
            TooltipSystem.show(sinkContent, sinkHeader);
        }
        else
        {
            TooltipSystem.show(dryerContent, dryerHeader);
        }

    }

    public void OnPointerExit(PointerEventData eventData)
    {
		TooltipSystem.hide();
	}
}
