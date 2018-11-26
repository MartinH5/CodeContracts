# CodeContracts


The code consists of a set of preconditions and postconditions for both classes. 

### Withdraw

For the withdraw method we check to make sure that:

1. The withdrawal amount is less or equal to the balance. 
2. The amount also has to be more than 0. 

And afterwards we check that:

1. The balance is still at or above 0. 
2. Balance is less than before.

```
Contract.Requires(amount <= balance && 0 < amount);
var temp = balance;
balance -= amount;
Contract.Ensures(balance < temp && balance >= 0);
```

### Deposit

Firstly:

1. The deposit amount is above 0.
2. The amount is not above the cap (100k) 

And afterwards: 

1. Balance is more than before.
2. Balance is not above the cap (100k) 

```
Contract.Requires(amount > 0 && amount < cap);
var temp = balance;
balance += amount;
Contract.Ensures(temp < balance && balance < cap);
```




Code can be found [here](https://github.com/MartinH5/CodeContracts/blob/master/CodeContract/CodeContract/AccountContract.cs) 
