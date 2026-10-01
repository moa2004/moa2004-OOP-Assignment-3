### Step 1
**What is the same?**
The underlying logic for all four methods (Add, GetById, GetAll, Remove) is completely identical. Both stores also use a `List` as the underlying data structure to hold the items.

**What is different?**
The only difference is the Data Type being manipulated. `StudentStore` operates on `Student` objects, while `CourseStore` operates on `Course` objects.

### Step 3
**Compiler Error:**
CS1061: 'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found.

**Explanation:**
The compiler rejects it because it doesn't know what type 'T' will be. 'T' could be any type (like string or int), and not all types have an 'Id' property. Therefore, the compiler prevents us from accessing a property that might not exist.

### Step 7
**Why 'new Store<int>()' does not compile:**
It does not compile because 'int' does not implement the 'IHasId' interface. The class 'Store<T>' has the constraint 'where T : IHasId'.

**What is the common name for the kind of class built in Steps 4 and 5?**
The Repository Pattern.