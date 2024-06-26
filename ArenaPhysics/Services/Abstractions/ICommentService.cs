﻿using ArenaPhysics.DTOs.Requests;
using ArenaPhysics.DTOs.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ArenaPhysics.Services.Abstractions
{
    public interface ICommentService
    {
        Task<List<CommentResponseDTO>> GetCommentsByProblemIdAsync(int problemId); // see comments under a particular problem
        Task AddCommentAsync(CommentRequestDTO comment); // add comment
        Task UpdateCommentAsync(CommentRequestDTO comment); // edit comment
        Task DeleteCommentByIdAsync(int id); //delete comment
        Task<CommentResponseDTO> GetCommentByIdAsync(int commentId);
    }
}
