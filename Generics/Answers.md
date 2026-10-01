### Step 1
**What is the same?**
The underlying logic for all four methods (Add, GetById, GetAll, Remove) is completely identical. Both stores also use a `List` as the underlying data structure to hold the items.

**What is different?**
The only difference is the Data Type being manipulated. `StudentStore` operates on `Student` objects, while `CourseStore` operates on `Course` objects.