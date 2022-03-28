using UnityEngine;
using System.Collections.Generic;

public class Delivery : MonoBehaviour
{
    private List<int> ownedPackages = new List<int>();

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Package"))
        {
            var deliveryIndex = other.GetComponent<DeliveryContainer>().delivery.index;
            ownedPackages.Add(deliveryIndex);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("DeliveryPoint"))
        {
            var deliveryIndex = other.GetComponent<DeliveryContainer>().delivery.index;
            if (!ownedPackages.Contains(deliveryIndex))
            {
                return;
            }

            ownedPackages.Remove(deliveryIndex);
            Destroy(other.gameObject);
        }
    }
}
