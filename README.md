# File System Explorer

## Overview

File System Explorer is an in-memory file explorer application developed in C#. The project demonstrates the practical use of multiple data structures by simulating common file system operations such as directory navigation, file indexing, file lookup, sorting, and searching.

The project integrates the following data structures:

* Doubly Linked List
* Stack
* Circular Linked List
* Queue
* Dictionary (HashMap)
* List

---

# Objectives

The objective of this project is to understand and implement various data structures and use them together in a single application.

The application supports:

* Managing directory contents
* Maintaining navigation history
* Tracking recent locations
* Processing indexing jobs
* Fast file lookup
* Sorting files
* Searching files using Binary Search

---

# Project Structure

## FileData.cs

Stores metadata associated with a file.

### Properties

* FileName
* CreatedDate
* Size
* Path

---

## DirectoryContents.cs

Implements a Doubly Linked List.

### Features

* Add file at beginning
* Add file at end
* Navigate to next file
* Navigate to previous file

### Data Structure Used

Doubly Linked List

---

## DirectoryHistory.cs

Maintains directory navigation history.

### Features

* Visit a directory
* Navigate back to previous directory

### Data Structure Used

Stack

---

## RecentLocations.cs

Maintains recently visited locations.

### Features

* Add recent location
* Cycle through locations

### Data Structure Used

Circular Linked List

---

## FileIndexer.cs

Processes indexing jobs in the order they arrive.

### Features

* Add indexing job
* Process indexing job

### Data Structure Used

Queue

---

## FileLookup.cs

Provides fast file retrieval using file paths.

### Features

* Add file metadata
* Lookup file by path

### Data Structure Used

Dictionary (HashMap)

---

## FileManager.cs

Handles sorting and searching operations.

### Features

* Sort by file name
* Sort by file size
* Binary search by file name

### Data Structure Used

List

---

# Data Structures Used

| Requirement         | Data Structure       |
| ------------------- | -------------------- |
| Directory Contents  | Doubly Linked List   |
| Directory History   | Stack                |
| Recent Locations    | Circular Linked List |
| File Indexing       | Queue                |
| File Lookup         | Dictionary           |
| Sorting & Searching | List                 |

---

# Edge Cases Handled

## Directory History

* Back navigation when history is empty

Output:

```text
Already at root
```

## File Lookup

* Searching for a non-existing file

Output:

```text
null
```

## File Indexer

* Processing an empty indexing queue

Output:

```text
No indexing jobs
```

## Circular Linked List

* Traversing when no recent locations exist

Handled safely without exceptions.

---

# Complexity Analysis

| Operation                    | Data Structure       | Time Complexity |
| ---------------------------- | -------------------- | --------------- |
| Add File At Beginning        | Doubly Linked List   | O(1)            |
| Add File At End              | Doubly Linked List   | O(1)            |
| Next File                    | Doubly Linked List   | O(1)            |
| Previous File                | Doubly Linked List   | O(1)            |
| Visit Directory              | Stack                | O(1)            |
| Go Back                      | Stack                | O(1)            |
| Add Recent Location          | Circular Linked List | O(1)            |
| Move To Next Recent Location | Circular Linked List | O(1)            |
| Add Indexing Job             | Queue                | O(1)            |
| Process Indexing Job         | Queue                | O(1)            |
| Add File To Lookup           | Dictionary           | O(1) Average    |
| Find File                    | Dictionary           | O(1) Average    |
| Sort By Name                 | List                 | O(n log n)      |
| Sort By Size                 | List                 | O(n log n)      |
| Binary Search                | List                 | O(log n)        |

---

# Testing

The project includes NUnit test cases covering:

* FileData initialization
* Directory history operations
* File lookup operations
* File indexing operations
* Sorting operations
* Binary search operations
* Edge cases
* Integrated workflows

Total Tests: 10+

Integrated Workflows:

1. File Addition → Lookup → Binary Search
2. Directory Navigation → History Management

---

# Technologies Used

* C#
* .NET
* NUnit Testing Framework
* Visual Studio

---

# Sample Workflow

1. Create file metadata using FileData.
2. Add files to directory contents.
3. Visit directories and store navigation history.
4. Add recent locations.
5. Queue files for indexing.
6. Store file information in Dictionary for fast lookup.
7. Sort files by name or size.
8. Search files using Binary Search.

---

# Conclusion

This project demonstrates how different data structures can be integrated to build a simplified file explorer. It provides practical experience with linked lists, stacks, queues, circular linked lists, dictionaries, sorting algorithms, and searching techniques while maintaining efficient time complexities for common operations.
