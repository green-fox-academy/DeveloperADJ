class TeamsController < ApplicationController
	
	before_action :authenticate_admin!

	def create
		@team = Team.new(team_params)

		@team.save
		redirect_to @team
	end

	def show
		@team = Team.find(params[:id])
				redirect_to :admin
	end

	def destroy
		@team = Team.find(params[:id])
		@team.destroy
		redirect_to :admin
	end

	private

	def team_params
		params.require(:team).permit(:name)
	end

end
