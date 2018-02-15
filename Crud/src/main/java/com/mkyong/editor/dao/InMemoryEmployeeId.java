package com.mkyong.editor.dao;

public class InMemoryEmployeeId implements GenerateEmployeeId {
    private static long id = 0;
    @Override
    public long getUniqueId() {
        id++;
        return id;
    }
}
