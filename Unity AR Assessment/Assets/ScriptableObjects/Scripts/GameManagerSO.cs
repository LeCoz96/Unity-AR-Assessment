using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameManagerSO", menuName = "GameManager")]
public class GameManagerSO : ScriptableObject
{
    [SerializeField] private List<NumbersSO> _listOfNumberSO;
    public List<NumbersSO> _editableList;

    private NumbersSO _targetSO;

    private bool _isFirstNumber = true;

    public NumbersSO GetCurrentNumber() { return _targetSO; }

    private int GetRandomNumberSO()
    {
        int Target = Random.Range(0, _editableList.Count);

        Debug.Log("Target: " + Target.ToString());

        Debug.Log("List Count: " + _editableList.Count);

        return Target;
    }

    private void ArrangeAllSO()
    {
        foreach (NumbersSO item in _listOfNumberSO)
        {
            _editableList.Add(item);
        }

        _editableList = _listOfNumberSO;
    }

    public void NextNumber()
    {
        if (_isFirstNumber)
        {
            ArrangeAllSO();

            _targetSO = _editableList[GetRandomNumberSO()];

            _isFirstNumber = false;
        }
        else
        {
            ArrangeAllSO();

            _editableList.Remove(_targetSO);

            _targetSO = _editableList[GetRandomNumberSO()];
        }
    }
}
