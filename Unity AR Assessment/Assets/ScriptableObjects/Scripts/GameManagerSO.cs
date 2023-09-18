using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameManagerSO", menuName = "GameManager")]
public class GameManagerSO : ScriptableObject
{
    [SerializeField] private List<NumbersSO> _listOfNumberSO;

    private NumbersSO _targetSO;

    [SerializeField] private bool _isFirstNumber = true;

    public NumbersSO GetCurrentNumber() { return _targetSO; }

    private int GetRandomNumberSO()
    {
        int Target = Random.Range(0, _listOfNumberSO.Count);

        return Target;
    }

    public void NextNumber()
    {
        if (_isFirstNumber)
        {
            _targetSO = _listOfNumberSO[GetRandomNumberSO()];

            _isFirstNumber = false;
        }
        else
        {
            _listOfNumberSO.Remove(_targetSO);

            _targetSO = _listOfNumberSO[GetRandomNumberSO()];
        }
    }
}
